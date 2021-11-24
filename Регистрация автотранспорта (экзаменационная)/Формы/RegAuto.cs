using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace Registration_autotransport
{
    public partial class RegAuto : Form //форма регистрации авто
    {
        readonly Transport trans = new();
        readonly User user = new();
        string choice_color;
        public RegAuto(object sender1, object sender2) //при создании формы передаем данные из объектов пользователей и автомобилей
        {
            InitializeComponent();
            user = (User)sender1;
            trans = (Transport)sender2;
            LoadComboboxFromDB(); //вызываем метод подгрузки из БД марок автомобилей в компонент ComboBox
        }


        //-----метод записи в БД из combobox -----// (оставил как напоминание для себя)

        //public bool MarksDB()
        //{
        //    
        //    try
        //    {
        //        string value = "";
        //        SqlConnection conn = DBSQLServerUtils.GetDBConnection();
        //        conn.Open();

        //        SqlCommand ins = new();
        //        ins.CommandType = System.Data.CommandType.Text;
        //        ins.CommandText = "INSERT marks_auto (marks) VALUES (@marks)";

        //        for (int i = 0; i < cmbMarka.Items.Count; i++)
        //        {
        //            ins.Parameters.Clear();
        //            value = cmbMarka.GetItemText(cmbMarka.Items[i]);
        //            ins.Parameters.AddWithValue("@marks", value);
        //            ins.Connection = conn;
        //            ins.ExecuteNonQuery();
        //        }              

        //        conn.Close();
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        return false;
        //    }
        //}

        //проверяем на корректность вводимых букв и цифр
        private void TxtVin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') 
             || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {
                lblVinError.Text = "";
            }
            else
            {
                e.Handled = true;
                lblVinError.Text = "Только латинские буквы и цифры";
            }
        }

        //При отмене очищаем поля
        private void BtnAutoCancel_Click(object sender, EventArgs e)
        {
            Logging.OverWriteInFile($"Пользователь {user.Login} отменил регистрацию автомобиля--{DateTime.Now}");
            cmbMarka.SelectedIndex = -1;
            txtModel.Text = "";
            txtColor.Focused.ToString();
            txtVin.Text = "";
            this.Close();         
        }

        //метод подгрузки из БД марок автомобилей в компонент ComboBox
        public bool LoadComboboxFromDB()
        {
            try
            {
                SqlConnection conn = DBSQLServerUtils.GetDBConnection();
                conn.Open();

                string sql = "SELECT marks FROM marks_auto";
                SqlCommand sel = new(sql, conn);
                SqlDataAdapter da = new (sql, conn);
                DataTable dt = new();
                da.Fill(dt);
                cmbMarka.DataSource = dt;
                cmbMarka.DisplayMember = "marks";
                cmbMarka.ValueMember = "marks";
                cmbMarka.Enabled = true;
                cmbMarka.SelectedIndex = -1;
                sel.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        //обрабатываем TextBox для возможности выбора цвета и закрашивания фона TextBox, а также получаем на основании выбранного цвета его имя
        private void TxtColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ();
            color.AllowFullOpen = false;
            color.ShowHelp = true;
            color.Color = txtColor.BackColor;

            if (color.ShowDialog() == DialogResult.OK)
            {
                txtColor.BackColor = color.Color;
                choice_color = color.Color.Name.ToString();
            }
            lblColorError.Text = "";
        }

        //Проверяем незаполненные поля и выводим сообщения в зависимости какое поле не заполнено
        private void BtnSuccess_Click(object sender, EventArgs e)
        {
            if (cmbMarka.SelectedIndex == -1 || txtModel.Text == "" || txtColor.BackColor == SystemColors.Window || (txtVin.Text == "" || txtVin.TextLength < 17))
            {
                if (cmbMarka.SelectedIndex == -1)
                {
                    lblMarksError.Text = "Вы не выбрали марку автомобиля";
                }

                if (txtModel.Text == "")
                {
                    lblModelError.Text = "Вы не заполнили поле Модель";
                }

                if (txtColor.BackColor == SystemColors.Window)
                {
                    lblColorError.Text = "Вы не заполнили поле Цвет";
                }

                if (txtVin.Text == "" || txtVin.TextLength < 17)
                {
                    lblVinError.Text = "Вы не заполнили поле VIN или неправильно заполнили, VIN состоит из 17 символов";
                }
            }
            else
            {
                //записываем данные с полей в объект Transports
                trans.Marks = cmbMarka.Text;
                trans.Model = txtModel.Text;
                trans.Color = choice_color;
                trans.Date_maked = dtpYear.Value;
                trans.Vin = txtVin.Text;

                DbMethods db = new();

                //вызываем метод проверки автомобиля из БД
                if (DbMethods.CheckAutoDbVin(trans) == true)
                {
                    cmbMarka.SelectedIndex = -1;
                    txtModel.Text = "";
                    txtColor.Text = "";
                    txtVin.Text = "";
                    lblAutoExist.Text = "Автомобиль с таким VIN-кодом уже зарегистрирован!";
                    lblAutoExist.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    //если такой не нашелся в БД, тогда вызываем метод записи нового авто в БД
                    if (db.InsertAutoDb(trans, user) == true)
                    {
                        Logging.OverWriteInFile($"Пользователь {user.Login} зарегистрировал новый автомобиль--{DateTime.Now}");
                        cmbMarka.SelectedIndex = -1;
                        txtModel.Text = "";
                        txtColor.Text = "";
                        txtVin.Text = "";
                        lblAutoExist.Text = "Запись успешно добавлена!";
                        lblAutoExist.ForeColor = System.Drawing.Color.Green;
                        btnAutoClose.Visible = true;
                    }
                    else
                    {
                        Logging.OverWriteInFile($"Произошел сбой в системе при попытке зарегистрировать новый автомобиль--{DateTime.Now}");
                        lblAutoExist.Text = "Что-то пошло не так!";
                        lblAutoExist.ForeColor = System.Drawing.Color.Red;
                    }

                }
            }
        }

        //методы очистки вспомогательных сообщени, при условии, если поля не пустые
        private void CmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarka.SelectedIndex != -1)
            {
                lblMarksError.Text = "";
            }
        }

        private void TxtModel_TextChanged(object sender, EventArgs e)
        {
            if (txtModel.Text != "")
            {
                lblModelError.Text = "";
            }
        }

        private void TxtVin_TextChanged(object sender, EventArgs e)
        {
            if (txtVin.Text != "")
            {
                lblVinError.Text = "";
            }
        }

        private void BtnAutoClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }


}
