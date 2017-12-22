using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RMS {
   
    class MainDBFacade {
        // This constant string is used thorugh out the application's Comboboxes to imply all results should be shown
        public const string COMBOBOX_ALL_OPTIOPNS_NAME= "Any";

        private DBDataContext db = new DBDataContext();

        public MainDBFacade() {

        }


        

        // Cretors
        
        public void createAccount(string uname, string password, int userTypeID) {
            if(UserNameExists(uname) == true) {
                throw new Exception("Username already exists in database");
            }

            User u = new User();
            u.UserName = uname;
            u.Password = HashGenerator.hasho(password).ToString();
            u.UserTypeID = userTypeID;

            db.Users.InsertOnSubmit(u);
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
                       where x.Number.Contains(number)
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

        private void updateUserAccount(User user) {
            //db.Users.
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
