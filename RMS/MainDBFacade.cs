using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RMS {
    

    class MainDBFacade {
        private DBDataContext db = new DBDataContext();

        public MainDBFacade() {

        }

        
        public void createAccount(string uname, string password, int userTypeID) {

        }

        public IEnumerable<string> getUserTypeNames() {
            return from x in db.UserTypes
                    select x.TypeName;
        }


    }
}
