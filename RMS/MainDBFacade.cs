using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RMS {
    

    class MainDBFacade {
        const string ALL_USER_TYPES_COMBOBOX_ITEM= "All types";
        private DBDataContext db = new DBDataContext();

        public MainDBFacade() {

        }

        
        public void createAccount(string uname, string password, int userTypeID) {
            if(UserNameExists(uname) == true) {
                throw new Exception("Username already exists in database");
            }

            User u = new User();
            u.UserName = uname;
            u.Password = password;
            u.UserTypeID = userTypeID;

            db.Users.InsertOnSubmit(u);
            db.SubmitChanges();
        }

        public IEnumerable<string> getUserTypeNames() {
            return from x in db.UserTypes
                    select x.TypeName;
        }

        public int UserTypeNameToID(string type_name) {
            
            return db.UserTypes.FirstOrDefault(x => x.TypeName == type_name).Id;
        }

        public bool UserNameExists(string uname) {
            return db.Users.FirstOrDefault(x => x.UserName == uname) != null;
        }

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


        public List<User> filterUsersByNameAndType(string name, string type) {
            List<User> data= db.Users.ToList();
            
            if(type != ALL_USER_TYPES_COMBOBOX_ITEM) {
                int type_id= UserTypeNameToID(type);
                data = db.UserTypes.First(x => x.Id == type_id).Users.ToList();
            }

            if(name != "") {
                data = data.Where(x => x.UserName.Contains(name)).ToList();
            }

            return data;
        }
    }

}
