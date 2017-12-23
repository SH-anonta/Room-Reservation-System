﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RMS {
   // Singleton class that handles all db query and update operation for this application
    class MainDBFacade {
        // This constant string is used thorugh out the application's Comboboxes to imply all results should be shown
        public const string COMBOBOX_ALL_OPTIOPNS_NAME= "Any";

        private DBDataContext db = new DBDataContext();

        private static MainDBFacade single_object;

        public static MainDBFacade getMainDBFacade() {
            if(single_object == null) {
                single_object = new MainDBFacade();
            }

            return single_object;
        }

        private MainDBFacade() {

        }

        // Cretors
        public void createAccount(string uname, string password, int userTypeID) {
            if(UserNameExists(uname) == true) {
                throw new DuplicateRecordException(string.Format("Username {0} already exists in database", uname));
            }

            User u = new User();
            u.UserName = uname;
            u.Password = HashGenerator.hasho(password).ToString();
            u.UserTypeID = userTypeID;

            db.Users.InsertOnSubmit(u);
            db.SubmitChanges();
        }

        public void createRoom(string number, string name, string type, string annex, int capacity) {

            if (RoomExists(number)) {
                throw new DuplicateRecordException(string.Format("Room number {0} already exists in database", number));
            }

            Room room = new Room();
            room.Number = number;
            room.Name = name;
            room.RoomType = db.RoomTypes.First(x => x.TypeName == type);
            room.Annex = db.Annexes.First(x => x.Name == annex);
            room.RoomCapacity = capacity;

            db.Rooms.InsertOnSubmit(room);
            db.SubmitChanges();
        }

        // create multiple rooms provided a range of room nunmbers
        public void createRooms(string number_start, string number_end, string type, string annex, int capacity) {
            int start = int.Parse(number_start.Trim());
            int end = int.Parse(number_end.Trim());

            if(start > end) {
                throw new Exception("Invalid range.. start is greater than end ");
            }

            if (AnyRoomInRangeExists(start, end)) {
                throw new DuplicateRecordException("One or more rooms with specified numbers already exist in database");
            }

            for(int i= start; i<= end; i++) {
                string room_name_number = i.ToString();
                createRoom(room_name_number, room_name_number, type, annex, capacity);
            }


        }

        public void createRoutineException(DateTime date, string weekday) {
            if (RoutineExceptionWihDateExists(date)) {
                throw new DuplicateRecordException("A routine exception with specified date already exists");
            }

            RoutineException re = new RoutineException();
            re.Date = date.Date;
            re.WeekDay = db.WeekDays.First(x=>x.Name == weekday);

            db.RoutineExceptions.InsertOnSubmit(re);
            db.SubmitChanges();
        }

        // Readers
        public IEnumerable<string> getUserTypeNames() {
            return from x in db.UserTypes
                    select x.TypeName;
        }

        
        public List<string> getRoomTypeNames() {
            var data = from x in db.RoomTypes
                       select x.TypeName;

            return data.ToList();
        }

        
        public List<string> getAnnexNames(){
            var data = from x in db.Annexes
                       select x.Name;

            return data.ToList();
        }

        public User getUser(string username) {
            return db.Users.First(x=> x.UserName == username);
        }

        public List<RoutineException> getAllRoutineExceptions() {
            return db.RoutineExceptions.ToList();
        }

        public List<string> getWeekDayNames() {
            return db.WeekDays.Select(x=>x.Name).ToList();
        }

        // Return Routine exceptions that have a date set to today's or later
        public List<RoutineException> getFutureRoutineExceptions() {
            return db.RoutineExceptions.Where(x => x.Date.Date >= DateTime.Now.Date).ToList();
        }

        // Filters (getters that return bsed on constraints)
        public List<User> filterUsersByNameAndType(string name, string type) {
            List<User> data= db.Users.ToList();
            
            if(type != COMBOBOX_ALL_OPTIOPNS_NAME) {
                int type_id= UserTypeNameToID(type);
                data = db.UserTypes.First(x => x.Id == type_id).Users.ToList();
            }

            if(name != "") {
                data = data.Where(x => x.UserName.Contains(name)).ToList();
            }

            return data;
        }

        public List<Room> filterRoomsByNumberTypeAnnex(string number, string type, string annex_name) {
            var data = db.Rooms.ToList();

            if(number != "") {
                 data = (from x in data
                       where x.Number.StartsWith(number)
                       select x).ToList();
            }

            if(type != COMBOBOX_ALL_OPTIOPNS_NAME) {
                data = (from x in data
                       where x.RoomType.TypeName == type
                       select x).ToList();
            }
            
            if(annex_name != COMBOBOX_ALL_OPTIOPNS_NAME) {
                data = (from x in data
                       where x.Annex.Name == annex_name
                       select x).ToList();
            }

            return data;
        }

        // Updaters

        public User updateUserAccount(string old_name, string new_name, string new_type, string new_password ) {
            User user= db.Users.First(x => x.UserName == old_name);

            user.UserName = new_name;
            user.UserType = db.UserTypes.First(x => x.TypeName == new_type);
            
            // if new password is blank, leave the acocunt's password unchanged
            if(new_password != "") {
                user.Password = HashGenerator.hasho(new_password).ToString();
            }
            
            db.SubmitChanges();
            return user;
        }

        // Deleters
        public void DeleteAccount(string uname) {
            User user = db.Users.FirstOrDefault(x => x.UserName == uname);

            if(user == null) return;

            db.Users.DeleteOnSubmit(user);
            db.SubmitChanges();
        }

        //  Utility

        public int UserTypeNameToID(string type_name) {
            return db.UserTypes.FirstOrDefault(x => x.TypeName == type_name).Id;
        }

        public bool UserNameExists(string uname) {
            return db.Users.FirstOrDefault(x => x.UserName == uname) != null;
        }

        public bool RoomExists(string room_number) {
            return db.Rooms.FirstOrDefault(x => x.Number == room_number) != null;
        }

        public bool AnyRoomInRangeExists(int start, int end) {
            for(int i= start; i<= end; i++) {
                if (RoomExists(i.ToString())) {
                    return true;
                }
            }

            return false;
        }

        public bool RoutineExceptionWihDateExists(DateTime date) {
            return db.RoutineExceptions.FirstOrDefault(x => x.Date.Date == date.Date) != null;
        }

        /*
         * User name:
         *  length must be between 4-20 characters long (inclusive)
         *  characters can only be alhabets, (numbers, spaces, and symbols are not allowed)
         */

        /*
         * Password:
         *  length must be between 8-50 characters long (inclusive)
         *  All characters are allowed
         */
    }

    class DuplicateRecordException: Exception {
        public DuplicateRecordException(){}
        public DuplicateRecordException(string msg): base(msg) {}
    }
    

    class HashGenerator {
        
        public static ulong mul(ulong b, ulong p, ulong MOD)
        {
            if (p == 0) return 0;
 
            ulong ret = mul(b, p / 2, MOD);
            ret += ret; ret %= MOD;
            if (p % 2 == 0) ret += b;
 
            return ret % MOD;
        }
 
        public static ulong hasho(string str)
        {
            ulong MOD = (ulong)100000000000007;
            int n = str.Length;
            ulong baseN = 311, p1 = 1, hashx = 0, a;
 
            for (int i = 0; i < n; i++){
                a = str[i]; a++;
                hashx += mul(p1, a, MOD); hashx %= MOD;
                p1 *= baseN; p1 %= MOD;
            }
 
            return hashx;
        }

    }

}
