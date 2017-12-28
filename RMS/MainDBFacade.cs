using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RMS {
   // Singleton class that handles all db query and update operation for this application
    class MainDBFacade {
        const string USER_TYPE_NAME_ADMIN= "Admin";
        const string USER_TYPE_NAME= "User";
        static Random RandomNumberGen= new Random();

        // This constant string is used thorugh out the application's Comboboxes to imply all results should be shown
        public const string COMBOBOX_ALL_OPTIOPNS_NAME= "Any";

        private DBDataContext db;

        private static MainDBFacade single_object;

        public static MainDBFacade getMainDBFacade() {
            if(single_object == null) {
                single_object = new MainDBFacade();
            }

            return single_object;
        }

        private MainDBFacade() {
             db = new DBDataContext();
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

        

        public void createReservation(DateTime start, DateTime end, int reservee_user_id, int room_id, string description) {

            if (roomIsOccupied(start, end, room_id)) {
                throw new RoomUnavalableException("This room is occupied during the specified time interval");
            }

            Reservation reserv = new Reservation();
            reserv.StartTime = start;
            reserv.EndTime = end;
            reserv.Room = getRoomByID(room_id);
            reserv.User = getUserById(reservee_user_id);
            reserv.Description = description;


            db.Reservations.InsertOnSubmit(reserv);
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
        public List<Reservation> getAllReservationsofUser(int id) {
            User user = getUserById(id);
            return user.Reservations.OrderBy(x=>x.StartTime).ToList();
        }

        public List<Reservation> getFutureReservationsofUser(int id) {
            User user = getUserById(id);
            DateTime today = DateTime.Now.Date;
            return user.Reservations.Where(x=>x.StartTime >= today).OrderBy(x=>x.StartTime).ToList();
        }

        public int UserNameToID(string user_name) {
            return db.Users.First(x=>x.UserName == user_name).Id;
        }
        public User getUserById(int id) {
            return db.Users.FirstOrDefault(x=> x.Id == id);
        }

        public WeekDay getWeekDayByName(string day_name) {
            return db.WeekDays.FirstOrDefault(x=>x.Name.ToLower() == day_name.ToLower());
        }

        public IEnumerable<string> getUserTypeNames() {
            return from x in db.UserTypes
                    select x.TypeName;
        }
        
        public Room getRoomByID(int id) {
            return db.Rooms.FirstOrDefault(x=> x.Id == id);
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
            return db.RoutineExceptions.OrderBy(x=>x.Date).ToList();
        }

        public List<string> getWeekDayNames() {
            return db.WeekDays.Select(x=>x.Name).ToList();
        }

        public RoutineException getRoutineException(int id) {
            return db.RoutineExceptions.First(x => x.Id == id);
        }

        public int getRoomTypeIdfromName(string name) {
            return db.RoomTypes.First(x=>x.TypeName == name).Id;
        }

        public RoutineException getRoutineExceptionOfDate(DateTime date) {
            date = date.Date;   // important so only dates are compared their not time 
            return db.RoutineExceptions.FirstOrDefault(x=> x.Date.Date == date);
        }

        public int getRoomIdFormRoomNumber(string room_number) {
            return db.Rooms.First(x => x.Number == room_number).Id;
        }

        public WeekDay getWeekdayOfDate(DateTime date) {
            date = date.Date;
            RoutineException exception = db.RoutineExceptions.FirstOrDefault(x=> x.Date.Date == date);

            if(exception != null) {
                return exception.WeekDay;
            }
            else{
                return getWeekDayByName(date.DayOfWeek.ToString());
            }
        }

        public List<RegularClass> getRegularClasses() {
            return db.RegularClasses.ToList();
        }

        public List<Reservation> getReservationsOfRoom(string room_number) {
            Room room = db.Rooms.First(x=> x.Number == room_number);
            return room.Reservations.ToList();
        }

        public bool roomHasReservations(string room_number) {
            Room room = db.Rooms.First(x=> x.Number == room_number);
            return room.Reservations.Count(x=> true) != 0;
        }

        public void deleteAllReservationsOfRoom(string room_number) {
            Room room = db.Rooms.First(x=> x.Number == room_number);

            foreach(Reservation res in room.Reservations) {
                db.Reservations.DeleteOnSubmit(res);
            }

            db.SubmitChanges();
        }

        // Return Routine exceptions that have a date set to today's or later
        public List<RoutineException> getFutureRoutineExceptions() {
            DateTime today = DateTime.Now.Date;
            return db.RoutineExceptions.Where(x => x.Date.Date >= today).OrderBy(x=>x.Date).ToList();
        }


        public List<Reservation> getAllReservations() {
            return db.Reservations.OrderBy(x=>x.StartTime).ToList();
        }

        public List<Reservation> getFutureReservations() {
            DateTime today = DateTime.Now.Date;
            return db.Reservations.Where(x=> x.StartTime.Date >= today).OrderBy(x=>x.StartTime).ToList();
        }

        
        public Reservation getRservation(int id) {
            return db.Reservations.First(x=>x.Id == id);
        }

        public RoomType getRoomType(int id) {
            return db.RoomTypes.First(x=>x.Id == id);
        }

        public bool roomTypeExists(string type_name) {
            return db.RoomTypes.FirstOrDefault(x=>x.TypeName == type_name) != null;
        }

        public bool annexExists(string annex_name) {
            return db.Annexes.FirstOrDefault(x=>x.Name == annex_name) != null;
        }

        public bool weekdayExists(string weekday_name) {
            return db.WeekDays.FirstOrDefault(x=>x.Name == weekday_name)!= null;
        }

        //returns room number as staring
        public string getRandomAvalableRoom(DateTime start, DateTime end, int min_capacity, int room_type_id) {
            RoomType room_type = getRoomType(room_type_id);

            //get rooms that are of room_type and are avalable during the start and end time interval
            List<string> rooms = room_type.Rooms.Where(x=> x.RoomCapacity >= min_capacity && !roomIsOccupied(start, end, x.Id)).Select(x=>x.Number).ToList();
            int count = rooms.Count;

            if(count == 0) {
                throw new NoRoomFoundException("No room of specified type is avalable during this time");
            }
            int picked = RandomNumberGen.Next(count);

            return rooms[picked];
        }

        public List<Room> getAvalableRooms(DateTime start, DateTime end, int min_capacity, int room_type_id) {
            RoomType room_type = getRoomType(room_type_id);

            //get rooms that are of room_type and are avalable during the start and end time interval
            return room_type.Rooms.Where(x=> x.RoomCapacity >= min_capacity && !roomIsOccupied(start, end, x.Id)).ToList();
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
            var data = db.Rooms.OrderBy(x=>x.Number).ToList();

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

        public bool accountTypeExists(string type_name) {
            return db.UserTypes.FirstOrDefault(x=>x.TypeName == type_name) != null;
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

        public void UpdateRoutineException(RoutineException row, string new_weekday) {
            row.WeekDay = db.WeekDays.First(x=>x.Name == new_weekday);
            db.SubmitChanges();
        }

        public void updateRoom(string number, string name, string type, string annex, int capacity) {
            Room room = db.Rooms.First(x=>x.Number == number);
            room.Number = number;
            room.Name = name;
            room.RoomType = db.RoomTypes.First(x => x.TypeName == type);
            room.Annex = db.Annexes.First(x => x.Name == annex);
            room.RoomCapacity = capacity;

            db.SubmitChanges();
        }

        // Deleters
        public void DeleteAccount(string uname) {
            User user = db.Users.FirstOrDefault(x => x.UserName == uname);

            if(user == null) return;

            db.Users.DeleteOnSubmit(user);
            db.SubmitChanges();
        }

        public void DeleteRoutineException(int id) {
            RoutineException to_delete = getRoutineException(id);

            db.RoutineExceptions.DeleteOnSubmit(to_delete);
            db.SubmitChanges();
        }

        public void deleteReservation(int id) {
            var res = db.Reservations.First();
            
            db.Reservations.DeleteOnSubmit(res);
            db.SubmitChanges();
        }

        public void deleteRoom(string room_number) {
            Room to_delete = db.Rooms.First(x=> x.Number == room_number);
            
            db.Rooms.DeleteOnSubmit(to_delete);
            db.SubmitChanges();

        }

        //  Utility
        public bool timeRangesOverlaps(DateTime st1, DateTime nd1, DateTime st2, DateTime nd2) {
            return !(nd1 <= st2 || nd2 <= st1);
        }

        public bool timeOfDayRangeOverlaps(DateTime st1, DateTime nd1, DateTime st2, DateTime nd2) {
            return !(nd1.TimeOfDay <= st2.TimeOfDay || nd2.TimeOfDay <= st1.TimeOfDay);
        }

        public bool roomIsOccupied(DateTime start, DateTime end, int room_id) {
            Room room = getRoomByID(room_id);

            // check for conflicts with other reservation
            var conflicts = room.Reservations.FirstOrDefault(x=> timeRangesOverlaps(x.StartTime, x.EndTime, start, end));
            
            // if an existing reservation has the same time
            if(conflicts != null) return true;


            // check for conflicts with regular classes
            WeekDay weekday = getWeekDayByName(start.DayOfWeek.ToString());

            // check if this day follows regular routine schedules
            RoutineException exception=  getRoutineExceptionOfDate(start);
            if(exception != null) {
                weekday = exception.WeekDay;
            }

           
            var regular_clases = room.RegularClasses.Where(x=>x.WeekDay == weekday);
            var conflicts2 = regular_clases.FirstOrDefault(x=>timeOfDayRangeOverlaps(x.StartTime, x.EndTime, start, end));

            if(conflicts2  == null) return false;
            else return true;
            
        }

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

        public bool LoginIsValid(string uname, string password) {
            User user = db.Users.FirstOrDefault(x=>x.UserName == uname);
            return HashGenerator.hasho(password).ToString() == user.Password;
        }


        public bool userIsAdmin(string user_name) {
            return getUser(user_name).UserType.TypeName == USER_TYPE_NAME_ADMIN;
        }
        
    }

    class DuplicateRecordException: Exception {
        public DuplicateRecordException(){}
        public DuplicateRecordException(string msg): base(msg) {}
    }

    class RoomUnavalableException: Exception {
        public RoomUnavalableException(){}
        public RoomUnavalableException(string msg): base(msg) {}
    }
    
    class NoRoomFoundException: Exception {
        public NoRoomFoundException(){}
        public NoRoomFoundException(string msg): base(msg) {}
    }

    class InvalidDataException: Exception {
        public InvalidDataException(){}
        public InvalidDataException(string msg): base(msg) {}
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


    class DataValidator{
        private static MainDBFacade db = MainDBFacade.getMainDBFacade();


        // validators
        private static bool usernameIsValid(string uname) {
            foreach(char ch in uname) {
                if(!(ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')) {
                    return false;
                }
            }

            return true;
        }
        

        public static bool validateUserDataForCreator(string uname, string password, string account_type, out string error_msg) {
            var errors = new List<string>();

            if (password == "" || uname == "" || account_type == "") {
                error_msg= "One or more required fields are empty";
                return false;
            }

            bool valid= true;

            if(uname.Length < 4) {
                valid= false;
                errors.Add("User name can not be less 4 charecters long");
            }
            if (!usernameIsValid(uname)) {
                valid= false;
                errors.Add("Username may only contain alphabets");
            }
            if (!db.accountTypeExists(account_type)) {
                valid= false;
                errors.Add("Invalid account type");
            }
            if(password.Length < 8) {
                valid= false;
                errors.Add("Password can not be less 8 charecters long");
            }
            
            
            error_msg=  string.Join("\n",errors);
            return valid;
                
        }

        public static bool validateUserDataForEditor(string uname, string password, string account_type, out string error_msg) {
            var errors = new List<string>();
            
            if (uname == "" || account_type == "") {
                error_msg= "One or more required fields are empty";
                return false;
            }

            bool valid= true;

            if(uname.Length < 4) {
                valid= false;
                errors.Add("User name can not be less 4 charecters long");
            }
            if (!usernameIsValid(uname)) {
                valid= false;
                errors.Add("Username may only contain alphabets");
            }
            if (!db.accountTypeExists(account_type)) {
                valid= false;
                errors.Add("Invalid account type");
            }
            if(password != "" && password.Length < 8) {
                valid= false;
                errors.Add("Password can not be less 8 charecters long");
            }
            
            
            error_msg=  string.Join("\n",errors);
            return valid;
                
        }

        static private bool roomNumberIsValid(string room_number) {

            try {
                int n = int.Parse(room_number);

                if(n < 1) {
                    return false;
                }
            }
            catch (FormatException ex){
                return false;
            }

            return true;
        }

        static private bool roomNameIsValid(string room_name) {
            foreach(char ch in room_name) {
                if(!(ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z' || ch >= '0' && ch  <= '9' || ch == ' ')) {
                    return false;
                }
            }

            return true;
        }

        static private bool roomCapacityIsValid(string capacity) {

            try {
                int n = int.Parse(capacity);
                if(n < 1) return false;
            }
            catch(FormatException ex) {
                return false;
            }

            return true;
        }

        public static bool validateRoomData(string number, string name, string type, string annex, string capacity, out string error_msg) {
            var errors = new List<string>();
            bool valid = true;

            error_msg="";

            if(number == "" || type =="" || annex == "" || capacity == "") {
                error_msg =  "One or more required fields are empty";
                return false;
            }

            if (!roomCapacityIsValid(capacity)) {
                valid= false;
                errors.Add("Invalid room capacity");
            }
            if (!roomNumberIsValid(number)) {
                valid= false;
                errors.Add("Invalid room number");
            }
            if (name != "" && !roomNameIsValid(name)) {
                valid= false;
                errors.Add("Room name may only contain lapha-numaric charecters and spaces");
            }
            if (!db.roomTypeExists(type)) {
                valid= false;
                errors.Add("Invalid room type");
            }
            if (!db.annexExists(annex)) {
                valid= false;
                errors.Add("Invalid annex name");
            }

            error_msg=  string.Join("\n",errors);
            return valid;
        }

        public static bool validateRoomNumberRange(string room_number_range) {

            var chunks = room_number_range.Split(',');

            if(chunks.Length != 2) return false;

            try {
                int l = int.Parse(chunks[0].Trim());
                int r = int.Parse(chunks[1].Trim());

                if(l > r) return false;
            }
            catch(FormatException ex) {
                return false;
            }
                
            
            return true;
        }

        public static bool validateLogin(string uname, string password, out string error_msg) {
            if(uname.Trim() == "" || password.Trim() == "") {
                error_msg= "One or more required fields are empty";
                return false;
            }
            if(!db.UserNameExists(uname)) {
                error_msg= "The requested account does not exist";
                return false;
            }

            
            if(!db.LoginIsValid(uname, password)) {
                error_msg= "Wrong password";
                return false;
            }

            error_msg= "";
            return true;
        }

        public static bool validateReservationData(DateTime start, DateTime end, string description, string roomNumber,string room_type, out string error_msg) {
            var errors = new List<string>();
            bool valid= true;
            
            if(description.Trim() == "" || roomNumber.Trim() == "") {
                error_msg= "One or more required fields are empty";
                return false;
            }

            if(start > end) {
                valid= false;
                errors.Add("Invalid reservation time");
            }

            if (!db.roomTypeExists(room_type)) {
                valid= false;
                errors.Add("Invalid room type");
            }
            
            error_msg=  string.Join("\n",errors);
            return valid;
        }

        public static bool validateReservationDataForRoomPicker(DateTime start, DateTime end, string description, string room_type, string min_capacity, out string error_msg) {
            var errors = new List<string>();
            bool valid= true;
            
            if(description.Trim() == "") {
                error_msg= "One or more required fields are empty";
                return false;
            }
            if(start > end) {
                valid= false;
                errors.Add("Invalid reservation time");
            }

            if (!db.roomTypeExists(room_type)) {
                valid= false;
                errors.Add("Invalid room type");
            }

            if (!roomCapacityIsValid(min_capacity)) {
                valid= false;
                errors.Add("Invalid room capacity");
            }
            
            error_msg=  string.Join("\n",errors);
            return valid;
        }

        public static bool validateRoutineException(string weekday, out string error_msg) {
            var errors = new List<string>();
            bool valid = true;

            
            if(weekday.Trim() == "") {
                error_msg= "One or more required fields are empty";
                return false;
            }

            if (!db.weekdayExists(weekday)) {
                valid = false;
                errors.Add("Invalid weekday");
            }

            error_msg=  string.Join("\n",errors);
            return valid;
        }
    }
}
