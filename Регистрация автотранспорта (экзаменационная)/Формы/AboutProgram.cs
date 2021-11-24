using System;
using System.Reflection;
using System.Windows.Forms;

namespace Registration_autotransport
{
    partial class AboutProgram : Form //Форма "о программе". Сгенерирован стандартными средствами Visual Studio
    {
        public AboutProgram()
        {
            InitializeComponent();
            this.Text = String.Format("О программе \"Регистрация автотранспорта\"");
            this.labelProductName.Text = "Система \"Регистрация автотранспорта\"";
            this.labelVersion.Text = "Версия 1.0.0";
            this.labelCopyright.Text = "Авторские права принадлежат автору и защищены";
            this.labelCompanyName.Text = "Автор:  Кузьмин Алексей Сергеевич";
            this.textBoxDescription.Text = "Система позволяет вести учет автотранспортных средств";
        }

        #region Методы доступа к атрибутам сборки

        public static string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
#pragma warning disable SYSLIB0012 // Тип или член устарел
                return System.IO.Path.GetFileNameWithoutExtension(path: Assembly.GetExecutingAssembly().CodeBase);
#pragma warning restore SYSLIB0012 // Тип или член устарел
            }
        }

        public static string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public static string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public static string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public static string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public static string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
