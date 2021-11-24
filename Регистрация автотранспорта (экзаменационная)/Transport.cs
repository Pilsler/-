using System;

namespace Registration_autotransport
{
    public class Transport //основной класс работы с транспортом
    {
        public string Marks { get; set; }
        public string Model { get; set; }
        public DateTime Date_maked { get; set; }
        public string Color { get; set; }
        public string Vin { get; set; }

        public Transport(){ }
    }
}
