using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Registration_autotransport
{
    public partial class EditAutoFrm : Form //форма редактирования данных
    {
        //Разные переменные для промежуточного хранения данных из БД
        private readonly User user = new();
        string choice_color = "";
        string marka = "";
        string mod = "";
        DateTime dt;
        string color = "";
        string vin = "";
        int id_clients = 0;
        int id_auto = 0;
        

        public EditAutoFrm(object sender)
        {
            user = (User)sender;
            InitializeComponent();
            LoadFromDB(); //при создании формы вызываем метод проверки пользователя из БД,
                          //затем загружаем из БД авто принадлежащие этому пользователю в DataGridView
            LoadToCmbMarks(); // при создании формы вызываем метод загрузки из БД списка марок автомобилей в ComboBox 
            lblOwner.Text = $"Список автомобилей, принадлежащих пользователю {user.Login}!";
        }

        //Метод загрузки из БД списка марок автомобилей в ComboBox в качестве коллекции.
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
                cmbEditMarks.DataSource = dt;
                cmbEditMarks.DisplayMember = "marks";
                cmbEditMarks.ValueMember = "marks";
                cmbEditMarks.Enabled = true;
                cmbEditMarks.SelectedIndex = -1;
                sel.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //метод проверки пользователя из БД, затем загружаем из БД авто принадлежащие этому пользователю в DataGridView
        private void LoadFromDB()
        {
            try
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

                dataGridEdit.Rows.Clear();
                SqlConnection conn = DBSQLServerUtils.GetDBConnection();
                conn.Open();
                string sql = "SELECT marks, model, date_maked, color, vin " +
                             "FROM transports, users_clients " +
                             "WHERE users_clients.id_clients = @id_clients AND transports.user_auto = @user_auto AND users_clients.username = @username";
                SqlCommand command = new(sql, conn);
                command.Parameters.AddWithValue("@id_clients", id_clients);
                command.Parameters.AddWithValue("@user_auto", id_clients);
                command.Parameters.AddWithValue("@username", user.Login);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new(); //создаем пустой список
                while (reader.Read()) //считываем данные и записываем их в список  
                {
                    data.Add(new string[6]);

                    data[^1][0] = reader[0].ToString(); //значения полей таблицы БД записываем в в список 
                    data[^1][1] = reader[1].ToString();
                    data[^1][2] = reader[2].ToString();
                    data[^1][3] = reader[3].ToString();
                    data[^1][4] = reader[4].ToString();

                }
                reader.Close();
                conn.Close();

                foreach (string[] s in data) //перебираем список и записываем значения в столбцы DataGridView
                    dataGridEdit.Rows.Add(s);
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        //При сохранении изменений проверяем не пустые ли поля
        private void BtnEditSave_Click(object sender, EventArgs e)
        {
            int count = 0;
            lblEditError.Text = "";
            if (cmbEditMarks.SelectedIndex == -1 || txtEditModel.Text == "" || txtEditColor.BackColor == SystemColors.Window || txtEditVin.Text == "")
            {
                lblEditError.Text = "Одно или несколько полей пустые";
                lblEditError.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                try
                {
                    //получаем ID автомобиля по тем данным, что были выбраны пользователем в DataGridView 
                    SqlConnection conn1 = DBSQLServerUtils.GetDBConnection();
                    conn1.Open();
                    string sqlUsers = "SELECT id_auto FROM transports WHERE marks = @marks AND model = @model AND date_maked = @date_maked AND color = @color AND vin = @vin";
                    SqlCommand command1 = new(sqlUsers, conn1);
                    command1.Parameters.AddWithValue("@marks", marka); //в качестве параметров передаются распарсенные данные из DataGridView
                    command1.Parameters.AddWithValue("@model", mod);
                    command1.Parameters.AddWithValue("@date_maked", dt);
                    command1.Parameters.AddWithValue("@color", color);
                    command1.Parameters.AddWithValue("@vin", vin);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    while (reader1.Read())
                    {
                        string s = reader1[0].ToString();
                        id_auto = Int32.Parse(s);
                    }
                    reader1.Close();
                    conn1.Close();

                    //Получаем все VIN-коды автомобилей из БД для сравнения с тем, что введет пользователь
                    SqlConnection conn2 = DBSQLServerUtils.GetDBConnection();
                    conn2.Open();
                    string sqlVin = "SELECT vin FROM transports";
                    SqlCommand command2 = new(sqlVin, conn2);
                    command2.Parameters.AddWithValue("@vin", vin);
                    SqlDataReader reader2 = command2.ExecuteReader();
                    while (reader2.Read())
                    {
                        if (reader2[0].ToString() == txtEditVin.Text)
                        {
                            count++;
                            break;
                        }
                    }
                    reader2.Close();
                    conn2.Close();

                    if (count > 0)
                    {
                        lblEditError.Text = "Такой VIN-код уже существует";
                        lblEditError.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        //Записываем в БД новые (редактированные) значения, сопоставляем с id_auto который ранее получили, для точности записи в БД 
                        SqlConnection conn = DBSQLServerUtils.GetDBConnection();
                        conn.Open();

                        SqlCommand ins = new();
                        ins.CommandType = System.Data.CommandType.Text;
                        ins.CommandText = "UPDATE transports SET marks = @marks, model = @model, date_maked = @date_maked, color = @color, vin = @vin WHERE id_auto = @id_auto";
                        ins.Parameters.AddWithValue("@marks", cmbEditMarks.Text);
                        ins.Parameters.AddWithValue("@model", txtEditModel.Text);
                        ins.Parameters.AddWithValue("@date_maked", dtpEditDate.Value);
                        ins.Parameters.AddWithValue("@color", choice_color);
                        ins.Parameters.AddWithValue("@vin", txtEditVin.Text);
                        ins.Parameters.AddWithValue("@id_auto", id_auto);

                        ins.Connection = conn;
                        ins.ExecuteNonQuery();

                        conn.Close();

                        Logging.OverWriteInFile($"Пользователь {user.Login} отредактировал данные по автомобилю--{DateTime.Now}");
                        lblEditError.Text = "Изменения успешно сохранены!";
                        lblEditError.ForeColor = System.Drawing.Color.Green;
                        dataGridEdit.Refresh();
                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.Message);
                }
            }
        }

        //Метод парсинга полей DataGridView для последующей промежуточной записи в переменные, на основании которых делаем запрос для получения id_auto 
        private void DataGridEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            cmbEditMarks.Text = dataGridEdit.Rows[dataGridEdit.CurrentRow.Index].Cells[0].Value.ToString();
            marka = cmbEditMarks.Text;
            txtEditModel.Text = dataGridEdit.Rows[dataGridEdit.CurrentRow.Index].Cells[1].Value.ToString();
            mod = txtEditModel.Text;
            DateTime date = DateTime.Parse(dataGridEdit.Rows[dataGridEdit.CurrentRow.Index].Cells[2].Value.ToString());
            dtpEditDate.Value = date;
            dt = dtpEditDate.Value;
            string s = dataGridEdit.Rows[dataGridEdit.CurrentRow.Index].Cells[3].Value.ToString();
            txtEditColor.BackColor = (Color)ColorTranslator.FromHtml(s);
            color = txtEditColor.BackColor.Name;
            txtEditVin.Text = dataGridEdit.Rows[dataGridEdit.CurrentRow.Index].Cells[4].Value.ToString();
            vin = txtEditVin.Text;
        }

        private void BtnEditClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //обрабатываем TextBox для возможности выбора цвета и закрашивания фона TextBox, а также получаем на основании выбранного цвета его имя
        private void TxtEditColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new();
            color.AllowFullOpen = false;
            color.ShowHelp = true;
            color.Color = txtEditColor.BackColor;

            if (color.ShowDialog() == DialogResult.OK)
            {
                txtEditColor.BackColor = color.Color;
                choice_color = color.Color.Name.ToString();
            }
        }
    }
}
