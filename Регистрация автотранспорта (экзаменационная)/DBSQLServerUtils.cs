using System.Data.SqlClient;

namespace Registration_autotransport
{
    class DBSQLServerUtils
    {
        //Метод передачи параметров для установления связи с БД

        public static SqlConnection GetDBConnection()
        {
            string datasource = @"123-ПК\SQLEXPRESS";
            string database = "RegisterAutoDB";
            string username = "sa";
            string password = "alexey_k";
            return GetDBConnection(datasource, database, username, password);
        }
        //Метод создания соединения с БД с полученными параметрами
        public static SqlConnection GetDBConnection(string datasource, string database, string username, string password)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new(connString);
            return conn;
        }
    }
}
