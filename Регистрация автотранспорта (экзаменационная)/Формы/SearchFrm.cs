using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Drawing;
using System.Data;

namespace Registration_autotransport
{
    public partial class SearchFrm : Form //форма поиска записи
    {   
        //несколько переменных для промежуточного хранения данных и БД
        readonly User user = new();
        string own = "";
        string choice_color = "";
        int id_clients = 0;


        public SearchFrm(object sender1)
        {
            user = (User)sender1; //получаем данные о пользователе из другой формы
            InitializeComponent();
            GetIDFromDB(); //вызываем метод запроса в БД по логину и пароля для получения ID пользователя

            //делаем неактивные элементы на форме, а некоторые скрываем
            lblTextSearch.Enabled = false;
            btnSearch.Enabled = false;
            btnExportAuto.Enabled = false;
            btnCloseSearch.Enabled = true;
            lblTextSearch.Hide();
            txtColor.Hide();
            dtpSearch.Hide();
            cmbMarks.Hide();
            txtSearch.Hide();

        }

        //проверяем поле возможность ввода некоторых символов и цифр
        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z')
             || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {
                lblSearchError.Text = "";
            }
            else
            {
                e.Handled = true;
                lblSearchError.Text = "Только латинские буквы и цифры";
                lblSearchError.ForeColor = System.Drawing.Color.Red;
            }
        }

        //выбираем через ComboBox по какому критериию будем искать авто. Далее по коду идут методы
        //которые в зависимости от выбранного критерия скрывают одни элементы на форме, а открывают для ввода/выбора другие,
        //а также задают некоторые свойства

        //поиск по марке авто
        private void CmbSearchMenu_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbSearchMenu.SelectedItem.ToString() == "Марка авто")
            {
                cmbMarks.Show();
                LoadToCmbMarks();
                txtSearch.Hide();
                txtColor.Hide();
                dtpSearch.Hide();
                txtSearch.Text = "";
                lblTextSearch.Enabled = true;
                btnSearch.Enabled = true;
                btnExportAuto.Enabled = true;
                btnCloseSearch.Enabled = true;
                lblTextSearch.Visible = true;
                lblTextSearch.Text = "Выберите марку автомобиля";
                lblTextSearch.Font = new Font("Segoe UI", 12);
            }

            //поиск по модели авто
            else if (cmbSearchMenu.SelectedItem.ToString() == "Модель авто")
            {
                txtSearch.Show();
                txtSearch.Enabled = true;
                cmbMarks.Hide();
                txtColor.Hide();
                dtpSearch.Hide();
                txtSearch.Text = "";
                lblTextSearch.Enabled = true;
                btnSearch.Enabled = true;
                btnExportAuto.Enabled = true;
                btnCloseSearch.Enabled = true;
                lblTextSearch.Visible = true;
                lblTextSearch.Text = "Введите модель автомобиля";
                lblTextSearch.Font = new Font("Segoe UI", 12);
            }

            //поиск по дате сборки авто
            else if (cmbSearchMenu.SelectedItem.ToString() == "Дата сборки авто")
            {
                cmbMarks.Hide();
                txtSearch.Hide();
                txtColor.Hide();
                txtSearch.Text = "";
                dtpSearch.Show();
                lblTextSearch.Enabled = true;
                btnSearch.Enabled = true;
                btnExportAuto.Enabled = true;
                btnCloseSearch.Enabled = true;
                lblTextSearch.Visible = true;
                lblTextSearch.Text = "Выберите дату сборки автомобиля";
                lblTextSearch.Font = new Font("Segoe UI", 12);
            }

            //поиск по цвету
            else if (cmbSearchMenu.SelectedItem.ToString() == "Цвет")
            {
                cmbMarks.Hide();
                txtColor.Show();
                txtSearch.Hide();
                dtpSearch.Hide();
                txtSearch.Text = "";
                lblTextSearch.Enabled = true;
                btnSearch.Enabled = true;
                btnExportAuto.Enabled = true;
                btnCloseSearch.Enabled = true;
                lblTextSearch.Visible = true;
                lblTextSearch.Text = "Выберите цвет автомобиля";
                lblTextSearch.Font = new Font("Segoe UI", 12);
                txtSearch.MaxLength = 50;
            }

            //поиск по VIN-коду
            else if (cmbSearchMenu.SelectedItem.ToString() == "VIN-код")
            {
                txtSearch.Show();
                cmbMarks.Hide();
                dtpSearch.Hide();
                txtColor.Hide();
                txtSearch.Text = "";
                lblTextSearch.Enabled = true;
                btnSearch.Enabled = true;
                btnExportAuto.Enabled = true;
                btnCloseSearch.Enabled = true;
                lblTextSearch.Visible = true;
                lblTextSearch.Text = "Введите VIN-код автомобиля";
                lblTextSearch.Font = new Font("Segoe UI", 12);
                txtSearch.MaxLength = 17;

            }
        }

        //Метод подгрузки в ComboBox марок автомобилей из таблицы БД
        public void LoadToCmbMarks()
        {
            try
            {
                SqlConnection conn = DBSQLServerUtils.GetDBConnection();
                conn.Open();

                string sql = "SELECT marks FROM marks_auto";
                SqlCommand sel = new(sql, conn);
                SqlDataAdapter da = new(sql, conn);
                DataTable dt = new();
                da.Fill(dt);
                cmbMarks.DataSource = dt;
                cmbMarks.DisplayMember = "marks";
                cmbMarks.ValueMember = "marks";
                cmbMarks.Enabled = true;
                cmbMarks.SelectedIndex = -1;
                sel.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //метод запроса в БД по логину и пароля для получения ID пользователя
        public void GetIDFromDB()
        {
            SqlConnection conn1 = DBSQLServerUtils.GetDBConnection();
            conn1.Open();
            string sqlUsers = "SELECT id_clients FROM users_clients WHERE username = @username AND pass = @pass";
            SqlCommand command1 = new(sqlUsers, conn1);
            command1.Parameters.AddWithValue("@username", user.Login);
            command1.Parameters.AddWithValue("@pass", user.Password);
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                string s = reader1[0].ToString();
                id_clients = Int32.Parse(s);
            }
            reader1.Close();
            conn1.Close();
        }

        //Метод поиска по марке авто из БД. Проверяем выбранную марку авто, а также по id пользователя проверяем что авто принадлежит именно этому пользователю
        public void SearchByMarka()
        {
            try
            {
                string marks = cmbMarks.Text;

                dataGrid.Rows.Clear();
                SqlConnection conn = DBSQLServerUtils.GetDBConnection();
                conn.Open();
                string sql = "SELECT username, marks, model, date_maked, color, vin " +
                             "FROM transports, users_clients " +
                             "WHERE transports.marks = @marks AND transports.user_auto = @id_clients AND users_clients.id_clients = @id_clients";
                SqlCommand command = new(sql, conn);
                command.Parameters.AddWithValue("@id_clients", id_clients);
                command.Parameters.AddWithValue("@user_auto", id_clients);
                command.Parameters.AddWithValue("@marks", marks);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new(); //создаем пустой список 
                while (reader.Read())
                {
                    data.Add(new string[6]);

                    own = reader[0].ToString();

                    data[^1][0] = reader[0].ToString(); //записываем в список данные из полей таблицы автомобилей из БД 
                    data[^1][1] = reader[1].ToString();
                    data[^1][2] = reader[2].ToString();
                    data[^1][3] = reader[3].ToString();
                    data[^1][4] = reader[4].ToString();
                    data[^1][5] = reader[5].ToString();

                }
                reader.Close();
                conn.Close();

                foreach (string[] s in data) //перебираем список и выводим в DataGridView
                    dataGrid.Rows.Add(s);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        //аналогичный метод поиска, уже по модели. Проверяем выбранную модель авто, а также по id пользователя проверяем что авто принадлежит именно этому пользователю
        public void SearchByModel()
        {
            try
            {
                string model = txtSearch.Text;

                dataGrid.Rows.Clear();
                SqlConnection conn = DBSQLServerUtils.GetDBConnection();
                conn.Open();
                string sql = "SELECT username, marks, model, date_maked, color, vin " +
                             "FROM transports, users_clients " +
                             "WHERE transports.model = @model AND transports.user_auto = @id_clients AND users_clients.id_clients = @id_clients";
                SqlCommand command = new(sql, conn);
                command.Parameters.AddWithValue("@id_clients", id_clients);
                command.Parameters.AddWithValue("@user_auto", id_clients);
                command.Parameters.AddWithValue("@model", model);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new();
                while (reader.Read())
                {
                    data.Add(new string[6]);

                    own = reader[0].ToString();

                    data[^1][0] = reader[0].ToString();
                    data[^1][1] = reader[1].ToString();
                    data[^1][2] = reader[2].ToString();
                    data[^1][3] = reader[3].ToString();
                    data[^1][4] = reader[4].ToString();
                    data[^1][5] = reader[5].ToString();

                }
                reader.Close();
                conn.Close();

                foreach (string[] s in data)
                    dataGrid.Rows.Add(s);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        //Метод поиска по дате сборки
        public void SearchByDate()
        {
            try
            {
                DateTime dt = dtpSearch.Value.Date;

                dataGrid.Rows.Clear();
                SqlConnection conn = DBSQLServerUtils.GetDBConnection();
                conn.Open();
                string sql = "SELECT username, marks, model, date_maked, color, vin " +
                             "FROM transports, users_clients " +
                             "WHERE transports.date_maked = @date_maked AND transports.user_auto = @id_clients AND users_clients.id_clients = @id_clients";
                SqlCommand command = new(sql, conn);
                command.Parameters.AddWithValue("@id_clients", id_clients);
                command.Parameters.AddWithValue("@user_auto", id_clients);
                command.Parameters.AddWithValue("@date_maked", dt);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new();
                while (reader.Read())
                {
                    data.Add(new string[6]);

                    own = reader[0].ToString();

                    data[^1][0] = reader[0].ToString();
                    data[^1][1] = reader[1].ToString();
                    data[^1][2] = reader[2].ToString();
                    data[^1][3] = reader[3].ToString();
                    data[^1][4] = reader[4].ToString();
                    data[^1][5] = reader[5].ToString();

                }
                reader.Close();
                conn.Close();

                foreach (string[] s in data)
                    dataGrid.Rows.Add(s);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        //Метод поиска по цвету. Используется имя цвета
        public void SearchByColor()
        {
            try
            {
                string color = choice_color;

                dataGrid.Rows.Clear();
                SqlConnection conn = DBSQLServerUtils.GetDBConnection();
                conn.Open();
                string sql = "SELECT username, marks, model, date_maked, color, vin " +
                             "FROM transports, users_clients " +
                             "WHERE transports.color = @color  AND transports.user_auto = @id_clients AND users_clients.id_clients = @id_clients";
                SqlCommand command = new(sql, conn);
                command.Parameters.AddWithValue("@id_clients", id_clients);
                command.Parameters.AddWithValue("@user_auto", id_clients);
                command.Parameters.AddWithValue("@color", color);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new();
                while (reader.Read())
                {
                    data.Add(new string[6]);

                    own = reader[0].ToString();

                    data[^1][0] = reader[0].ToString();
                    data[^1][1] = reader[1].ToString();
                    data[^1][2] = reader[2].ToString();
                    data[^1][3] = reader[3].ToString();
                    data[^1][4] = reader[4].ToString();
                    data[^1][5] = reader[5].ToString();

                }
                reader.Close();
                conn.Close();

                foreach (string[] s in data)
                    dataGrid.Rows.Add(s);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        //Метод поиска по VIN-коду
        public void SearchByVin()
        {
            try
            {
                string vin = txtSearch.Text;

                dataGrid.Rows.Clear();
                SqlConnection conn = DBSQLServerUtils.GetDBConnection();
                conn.Open();
                string sql = "SELECT username, marks, model, date_maked, color, vin " +
                             "FROM transports, users_clients " +
                             "WHERE transports.vin = @vin AND transports.user_auto = @id_clients AND users_clients.id_clients = @id_clients";
                SqlCommand command = new(sql, conn);
                command.Parameters.AddWithValue("@id_clients", id_clients);
                command.Parameters.AddWithValue("@user_auto", id_clients);
                command.Parameters.AddWithValue("@vin", vin);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new();
                while (reader.Read())
                {
                    data.Add(new string[6]);

                    own = reader[0].ToString();

                    data[^1][0] = reader[0].ToString();
                    data[^1][1] = reader[1].ToString();
                    data[^1][2] = reader[2].ToString();
                    data[^1][3] = reader[3].ToString();
                    data[^1][4] = reader[4].ToString();
                    data[^1][5] = reader[5].ToString();

                }
                reader.Close();
                conn.Close();

                foreach (string[] s in data)
                    dataGrid.Rows.Add(s);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void BtnCloseSearch_Click(object sender, EventArgs e)
        {
            this.Close();
            Logging.OverWriteInFile($"Пользователь {user.Login} закрыл форму поиска автомобиля--{DateTime.Now}");
        }

        //Метод выгрузки найденных записей во внешний файл. Перебираем ячейки DataGridView и проверяем есть ли в них значения
        private void BtnExportAuto_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                for (int j = 0; j < dataGrid.ColumnCount; j++)
                {
                    if (dataGrid.Rows[i].Cells[j].Value == null)
                    {
                        lblGridEmpty.Text = "Выгружать нечего!";
                        lblGridEmpty.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }

            lblGridEmpty.Text = "";

            //если значения в DataGridView найдены, делаем запись в файл
            string filePath = $"{own}.txt";
            using (FileStream fs = new(filePath, FileMode.Create))
            {
                using StreamWriter sw = new(fs, Encoding.Unicode);

                for (int i = 0; i < dataGrid.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGrid.Columns.Count; j++)
                    {
                        sw.Write($"{dataGrid.Rows[i].Cells[j].Value} | ");

                        if (j != dataGrid.Columns.Count - 1)
                        {
                            sw.Write(" | ");
                        }
                    }
                    sw.WriteLine();
                }
            }
            Logging.OverWriteInFile($"Пользователь {user.Login} сделал экспорт данных о автомобиле во внешний файл {own}.txt--{DateTime.Now}");
            lblGridEmpty.Text = "Успешно выгружено!";
            lblGridEmpty.ForeColor = System.Drawing.Color.Green;

        }

        //Метод проверки выбранного критерия поиска через элемент ComboBox.
        //В зависимости от выбранного Item вызывается соответствующий метод
        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtSearch.Text != "" || cmbSearchMenu.SelectedIndex == 2 || cmbSearchMenu.SelectedIndex == 3 || cmbMarks.SelectedIndex != -1)
            {
                lblSearchError.Text = "";
            }
            else
            {
                lblSearchError.Text = "Вы ничего не ввели или не выбрали!";
                lblSearchError.ForeColor = System.Drawing.Color.Red;          
            }

            if (cmbSearchMenu.SelectedIndex == 0)
            {
                SearchByMarka();
            }
            else if (cmbSearchMenu.SelectedIndex == 1)
            {
                SearchByModel();
            }
            else if (cmbSearchMenu.SelectedIndex == 2)
            {
                SearchByDate();
            }
            else if (cmbSearchMenu.SelectedIndex == 3)
            {
                SearchByColor();
            }
            if (cmbSearchMenu.SelectedIndex == 4)
            {
                SearchByVin();
            }
            
        }

        //обрабатываем TextBox для возможности выбора цвета и закрашивания фона TextBox, а также получаем на основании выбранного цвета его имя
        private void TxtColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog color = new();
            color.AllowFullOpen = false;
            color.ShowHelp = true;
            color.Color = txtColor.BackColor;

            if (color.ShowDialog() == DialogResult.OK)
            {
                txtColor.BackColor = color.Color;
                choice_color = color.Color.Name.ToString();
            }
        }

    }
}
