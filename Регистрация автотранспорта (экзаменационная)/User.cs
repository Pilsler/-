using System;


namespace Registration_autotransport
{
    public class User : Users //основной класс работы с пользователем
        {
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime Date { get; set; }

        public User() : base() { }
    }
}
