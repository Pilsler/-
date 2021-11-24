using System;
using System.Windows.Forms;


namespace Registration_autotransport
{
    public partial class MenuFrm : Form //Форма с меню
    {
        readonly User user = new();
        readonly Transport trans = new();

        public MenuFrm(object sender1, object sender2) //при создании формы получаем объекты пользователей и авто, для передачи в другие формы
        {
            InitializeComponent();
            user = (User)sender1;
            trans = (Transport)sender2;

            lblWelcome.Text = $"Добро пожаловать {user.Login}!";
        }

        private void BtnRegTransport_Click(object sender, EventArgs e)
        {
            RegAuto auto = new(user, trans);
            auto.Show();
        }

        private void BtnSearchTransport_Click(object sender, EventArgs e)
        {
            SearchFrm search = new(user);
            search.Show();
        }

        private void BtnCloseMenuFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditAuto_Click(object sender, EventArgs e)
        {
            EditAutoFrm edit = new(user);
            edit.Show();
        }
    }
}
