using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace Registration_autotransport
{
    public class DbMethods
    {
        public int IdClients = 0; //переменная для хранения ID пользователя при загрузке из БД

        public static bool CheckDbUser(object sender)
        {
            User user = (User)sender; // получаем объект пользователей из другой формы
            int count = 0;

            SqlConnection conn = DBSQLServerUtils.GetDBConnection(); //соединяемся с БД
            conn.Open();         
            string sql = "SELECT * FROM users_clients WHERE username = @username AND pass = @pass"; //создаем запрос на чтение данных из БД
            SqlCommand command = new(sql, conn); //создаем объект SQL-запроса и передаем в него в качестве параметра текст запроса
            command.Parameters.AddWithValue("@username", user.Login); //передаем в качестве параметров член-данные объекта пользователя
            command.Parameters.AddWithValue("@pass", user.Password); // аналогично
            SqlDataReader reader = command.ExecuteReader();  //создаем объект чтения ответа
            while (reader.Read())  // читаем результат пока есть что читать
            {
                if (reader[1].ToString() == user.Login) //проверяем из БД поле username с полем login в объекте
                {
                    count++; //наращиваем значение
                    reader.Close();
                    break;
                }
            }
            if (count > 0) //проверяем есть ли уже такая запись (значит совпадение обнаружено или нет)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        //Метод проверки автомобиля в БД при условии совпадения VIN-кода из БД и объекта класса Transports
        public static bool CheckAutoDbVin(object sender)
        {      
            int count = 0;
            Transport trans = (Transport)sender;
            SqlConnection conn = DBSQLServerUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT * FROM transports WHERE vin = @vin";
            SqlCommand command = new(sql, conn);
            command.Parameters.AddWithValue("@vin", trans.Vin);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader[6].ToString() == trans.Vin)
                {
                    count++;
                    reader.Close();
                    break;
                }
            }
            if (count > 0)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        //Метод проверки автомобиля в БД при условии совпадения марки авто из БД и объекта класса Transports
        public static bool CheckAutoDbMarks(object sender)
        {
            Transport trans = (Transport)sender;
            int count = 0;

            SqlConnection conn = DBSQLServerUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT * FROM transports WHERE marks = @marks";
            SqlCommand command = new(sql, conn);
            command.Parameters.AddWithValue("@marks", trans.Marks);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader[2].ToString() == trans.Marks)
                {
                    count++;
                    reader.Close();
                    break;
                }
            }
            if (count > 0)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }
        //Метод проверки автомобиля в БД при условии совпадения модели из БД и объекта класса Transports
        public static bool CheckAutoDbModel(object sender)
        {
            Transport trans = (Transport)sender;
            int count = 0;

            SqlConnection conn = DBSQLServerUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT * FROM transports WHERE model = @model";
            SqlCommand command = new(sql, conn);
            command.Parameters.AddWithValue("@model", trans.Model);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader[3].ToString() == trans.Model)
                {
                    count++;
                    reader.Close();
                    break;
                }
            }
            if (count > 0)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        //Метод проверки автомобиля в БД при условии совпадения даты сборки авто из БД и объекта класса Transports
        public static bool CheckAutoDbDate(object sender)
        {
            Transport trans = (Transport)sender;
            int count = 0;

            SqlConnection conn = DBSQLServerUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT * FROM transports WHERE date = @date";
            SqlCommand command = new(sql, conn);
            command.Parameters.AddWithValue("@date", trans.Date_maked);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader[4].ToString() == trans.Date_maked.ToShortDateString())
                {
                    count++;
                    reader.Close();
                    break;
                }
            }
            if (count > 0)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        //Метод проверки автомобиля в БД при условии совпадения кода цвета из БД и объекта класса Transports
        public static bool CheckAutoDbColor(object sender)
        {
            Transport trans = (Transport)sender;
            int count = 0;

            SqlConnection conn = DBSQLServerUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT * FROM transports WHERE color = @color";
            SqlCommand command = new(sql, conn);
            command.Parameters.AddWithValue("@color", trans.Color);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader[5].ToString() == trans.Color)
                {
                    count++;
                    reader.Close();
                    break;
                }
            }
            if (count > 0)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        //Добавляем пользователя в БД, данные передаем из объекта User
        public static bool InsertUserDb(object sender)
        {
            User user = (User)sender;
            try
            {
                SqlConnection conn = DBSQLServerUtils.GetDBConnection();
                conn.Open();

                SqlCommand ins = new();
                ins.CommandType = System.Data.CommandType.Text;
                ins.CommandText = "INSERT users_clients (username, pass, date) VALUES (@username, @pass, @date)";
                ins.Parameters.AddWithValue("@username", user.Login);
                ins.Parameters.AddWithValue("@pass", user.Password);
                ins.Parameters.AddWithValue("@date", user.Date);
                ins.Connection = conn;
                ins.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        //Добавляем авто в БД от лица пользователя. Сначала делаем выборку пользователя из БД.
        //Затем получаем его ID и записываем в переменную IdClients. Далее связываем эти сведения при записи авто в БД
        public bool InsertAutoDb(object sender1, object sender2)
        {
            Transport trans = (Transport)sender1;
            User user = (User)sender2;
            try
            {
                SqlConnection conn = DBSQLServerUtils.GetDBConnection();
                conn.Open();
                string sqlUsers = "SELECT id_clients FROM users_clients WHERE username = @username AND pass = @pass";
                SqlCommand command = new(sqlUsers, conn);
                command.Parameters.AddWithValue("@username", user.Login);
                command.Parameters.AddWithValue("@pass", user.Password);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string s = reader[0].ToString();
                    IdClients = Int32.Parse(s);
                }
                reader.Close();
                conn.Close();

                //записываем авто в БД

                conn.Open();
                SqlCommand ins = new();
                ins.CommandType = System.Data.CommandType.Text;
                ins.CommandText = "INSERT transports (user_auto, marks, model, date_maked, color, vin, users) VALUES (@user_auto, @marks, @model, @date_maked, @color, @vin, @users)";
                ins.Parameters.AddWithValue("@user_auto", IdClients); //добавляем тот самый ранее полученный id в таблицу с авто делаем привязку
                ins.Parameters.AddWithValue("@marks", trans.Marks);
                ins.Parameters.AddWithValue("@model", trans.Model);
                ins.Parameters.AddWithValue("@date_maked", trans.Date_maked);
                ins.Parameters.AddWithValue("@color", trans.Color);
                ins.Parameters.AddWithValue("@vin", trans.Vin);
                ins.Parameters.AddWithValue("@users", user.Login);
                ins.Connection = conn;
                ins.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        //Метод получения из БД всех записей по всем автомобилям и записываем по внешний файл
        public static void ExportsAllCars()
        {
            try
            {
                string filePath = "AllCars.txt";
                using (FileStream fs = new(filePath, FileMode.Create))
                {}             
                SqlConnection conn = DBSQLServerUtils.GetDBConnection();
                conn.Open();
                string sqlUsers = "SELECT * FROM transports";
                SqlCommand command = new(sqlUsers, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    using FileStream fs = new(filePath, FileMode.Append);
                    using StreamWriter sw = new(fs, Encoding.Unicode);
                    sw.WriteLine($"{reader[2]} | {reader[3]} | {reader[4]} | {reader[5]} | {reader[6]} | {reader[7]}");
                }
                reader.Close();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
