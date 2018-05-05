using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm {
    class DBInterface {
        String dbName, host, username, password;
        public DBInterface() {

        }
        public void setDatabase(String db) {
            this.dbName = db;
        }
        public void setHost(String hs) {
            this.host = hs;
        }
        public void setUsername(String us) {
            this.username = us;
        }
        public void setPassoword(String pw) {
            this.password = pw;
        }
        public void makeDB() {

        }
    }
}
