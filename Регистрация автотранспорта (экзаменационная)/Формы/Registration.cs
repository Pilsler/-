using System;
using System.Windows.Forms;


namespace Registration_autotransport
{
    public partial class RegistrationFrm : Form //Форма регистрации нового пользователя
    {
        readonly User user = new();
        public RegistrationFrm(object sender1)
        {
            InitializeComponent();
            user = (User)sender1;
        }

        //очищаем поля при отмене и вызываем форму авторизации
        private void BtnRegCancel_Click(object sender, EventArgs e)
        {
            txtLoginReg.Text = "";
            txtPasswordReg.Text = "";
            datePickerReg.Text = "";
            this.Close();
            AuthorizationFrm auth = new();
            auth.Show();
        }

        //проверка полей на пустые значения
        private void BtnRegOk_Click(object sender, EventArgs e)
        {
            if (txtLoginReg.Text == "" || txtPasswordReg.Text == "")
            {
                if (txtLoginReg.Text == "")
                {
                    lblInvalidLogin.Text = "Вы не заполнили поле Логин";
                }

                if (txtPasswordReg.Text == "")
                {
                    lblInvalidPass.Text = "Вы не заполнили поле Пароль";
                }

            }
            else
            {
                //если значения не пустые, передаем данные с полей в объект
                user.Login = txtLoginReg.Text;
                user.Password = txtPasswordReg.Text;
                user.Date = datePickerReg.Value;

                //вызываем метод проверки существующего пользователя в БД
                if (DbMethods.CheckDbUser(user) == true)
                {
                    Logging.OverWriteInFile($"Неверная попытка зарегистрировать пользователя--{DateTime.Now}");
                    txtLoginReg.Text = "";
                    txtPasswordReg.Text = "";
                    datePickerReg.Text = "";
                    lblInsertSuccess.Text = "Такой пользователь уже существует!";
                    lblInsertSuccess.ForeColor = System.Drawing.Color.Red;

                }
                else
                {
                    //если пользователь не существует, вызываем метод записи нового пользователя 
                    if (DbMethods.InsertUserDb(user) == true)
                    {
                        Logging.OverWriteInFile($"Зарегистрирован новый пользователь {user.Login}--{DateTime.Now}");
                        txtLoginReg.Text = "";
                        txtPasswordReg.Text = "";
                        datePickerReg.Text = "";
                        lblInsertSuccess.Text = "Запись успешно добавлена!";
                        lblInsertSuccess.ForeColor = System.Drawing.Color.Green;
                        btnCloseRegForm.Visible = true;
                    }
                    else
                    {
                        Logging.OverWriteInFile($"Сбой на этапе регистрации пользователя--{DateTime.Now}");
                        lblInsertSuccess.Text = "Что-то пошло не так!";
                        lblInsertSuccess.ForeColor = System.Drawing.Color.Red;
                    }

                }
            }
        }
        //если поля не пустые, скрываем вспомогательные сообщения
        private void TxtLoginReg_TextChanged(object sender, EventArgs e)
        {
            if (txtLoginReg.Text != "")
            {
                lblInvalidLogin.Text = "";
            }         
        }

        private void TxtPasswordReg_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswordReg.Text != "")
            {
                lblInvalidPass.Text = "";
            }
        }
        //закрываем форму и открываем форму авторизации
        private void BtnCloseRegForm_Click(object sender, EventArgs e)
        {
            this.Close();
            AuthorizationFrm auth = new();
            auth.Show();
        }
    }
}
