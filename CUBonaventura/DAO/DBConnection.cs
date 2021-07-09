using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUBonaventura.DAO
{
    class DBConnection
    {
        private string server, database, uid, password;
        public string connectionString()
        {
            /* NON-LOCALHOST 1 */
            //server = "sql12.freemysqlhosting.net"; database = "sql12293453"; uid = "sql12293453"; password = "2QhzduFA9H";

            /* NON-LOCALHOST 2 */
            //server = "ftpupload.net"; database = "epiz_23964390_db_cubv"; uid = "epiz_23964390"; password = "wzPhI3Vii8";

            /* NON-LOCALHOST 3 */
            /* IT WORK */
            //server = "remotemysql.com"; database = "ievuhRWMIr"; uid = "ievuhRWMIr"; password = "qcRe6zmK7n";

            server = "sql302.unaux.com"; database = "unaux_24235236_dbcubv"; uid = "unaux_24235236"; password = "c8q0ooz";

            /* LOCALHOST */
            /* PAKAI INI */
            //server = "localhost"; database = "dbcubv"; uid = "root"; password = "";

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            return connectionString;
        }
    }
}
