using System;
using System.Windows.Forms;

namespace Registration_autotransport
{
    public partial class AuthorizationFrm : Form //форма авторизации пользователя
    {
        //создаем новые объекты для чтения данных из них
        readonly User user = new();
        readonly Transport trans = new();

        public AuthorizationFrm()
        {
            InitializeComponent();
            Logging.WriteInFile(); //вызываем метод для создания пустого лог-файла событий
        }

        //Проверяем заполнены ли все поля, если нет, через Label выводим сообщения что не все заполнено. Затем проверяем есть такой пользователь
        private void BtnAuthOk_Click(object sender, EventArgs e)
        {
            if (txtLoginAuth.Text == "" || txtPasswordAuth.Text == "")
            {
                if (txtLoginAuth.Text == "")
                {
                    lblInvalidLoginAuth.Text = "Вы не заполнили поле Логин";
                }

                if (txtPasswordAuth.Text == "")
                {
                    lblInvalidPasswordAuth.Text = "Вы не заполнили поле Пароль";
                }
            }
            else
            {

                user.Login = txtLoginAuth.Text;
                user.Password = txtPasswordAuth.Text;

                //Вызываем метод проверки пользователя из БД. Если все удачно, вызываем форму с меню
                if (DbMethods.CheckDbUser(user) == true)
                {
                    Logging.OverWriteInFile($"Авторизация пользователя {user.Login}--{DateTime.Now}"); //для логирования. Вызываем метод дозаписи в созданный лог-файл
                    txtLoginAuth.Text = "";
                    txtPasswordAuth.Text = "";
                    MenuFrm transport = new(user, trans);
                    transport.Show();
                }
                else
                {
                    Logging.OverWriteInFile($"Неверная попытка авторизации--{DateTime.Now}");
                    txtLoginAuth.Text = "";
                    txtPasswordAuth.Text = "";
                    lblErrorAuth.Text = "Такой учетной записи не существует!";
                    lblErrorAuth.ForeColor = System.Drawing.Color.Red;
                    
                }
            }

        }
        //При нажатии кнопки "Отмена" очищаем все поля
        private void BtnAuthCancel_Click(object sender, EventArgs e)
        {
            txtLoginAuth.Text = "";
            txtPasswordAuth.Text = ""; 
        }

        //Вызываем форму регистрации пользователя
        private void BtnAuthReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationFrm reg = new (user);
            reg.Show();
        }

        //При нажатии "Выход", вызываем метод экспорта все автомобилей во внешний файл.
        //А также проверяем залогинился ли ранее пользователь, если да, то записываем эту информацию в лог-файл
        private void BtnClose_Click(object sender, EventArgs e)
        {
            DbMethods.ExportsAllCars();
            if (user.Login != null)
            {
                Logging.OverWriteInFile($"Пользователь {user.Login} вышел из системы--{DateTime.Now}");
                Logging.OverWriteInFile($"******************************************");
                this.Close();
            }
            else
            {
                this.Close();
            }           
        }

        //Если поля не пустые, скрываем сообщения из Label что поле не заполнено
        private void TxtLoginAuth_TextChanged_1(object sender, EventArgs e)
        {
            if (txtLoginAuth.Text != "")
            {
                lblInvalidLoginAuth.Text = "";
            }
        }

        private void TxtPasswordAuth_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPasswordAuth.Text != "")
            {
                lblInvalidPasswordAuth.Text = "";
            }
        }
        //Вызов формы "О программе"
        private void BtnAboutProgram_Click(object sender, EventArgs e)
        {
            AboutProgram about = new();
            about.Show();
        }
    }
}
