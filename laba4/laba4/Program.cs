using System;
// Перевірка на відповідність CLS
[assembly: CLSCompliant(true)]
namespace EDMSConsole
{
    class Program
    {
        enum MenuOptions : byte
        {
            // Авторизація
            SingIn = 1,
            // Реєстрація
            SingUp = 2,
            // Вийти з програми
            Exit,
        }
        class Autoriz
        {
            #region Fields
            // Поля, в яких зберігаються значення
            private string _login;
            private string _password;
            #endregion

            #region Properties
            /// <summary>
            /// Властивості, які контролюють
            /// доступ до полів
            /// </summary>  
            public string usLogin // Логін
            {
                get { return _login; }
                set { _login = value; }
            }
            public string usPass// Пароль
            {
                get { return _password; }
                set { _password = value; }
            }
            #endregion

            #region Constructors
            /*Конструктор - задає початкові значення для влстивостей та полів*/
            public Autoriz()
            {
                usLogin = "admin";
                usPass = "admin";
            }
            #endregion

            #region Methods
            public override string ToString()
            {
                return $"Логін:\t{usLogin}{Environment.NewLine}"+
                $"Пароль:\t{usPass}{Environment.NewLine}";
            }
            #endregion
        }
        class UserInfo
        {
            #region Fields
            // Поля, в яких зберігаються значення
            private string _name;
            private string _mail;

            #endregion

            #region Properties
            public string usName// Ім'я
            {
                get { return _name; }
                set { _name = value; }
            }
            public string usMail// Пошта
            {
                get { return _mail; }
                set { _mail = value; }
            }
            #endregion


            #region Constructors
            //Конструктор - задає початкові значення для влстивостей та полів
            public UserInfo()
            {
                usName = "Vitalii";
                usMail = "admin@gmail.com";
            }
            #endregion


            #region Methods
            public override string ToString()
            {
                return $"\nІм'я:\t{usName}{Environment.NewLine}" +
                $"Пошта:\t{usMail}";
            }
            #endregion
        }
        public static void SingIn()
        {
            int pass = 0;
            UserInfo usNmMl = new UserInfo();
            Autoriz usLgPs = new Autoriz();
            Console.WriteLine($"Авторизація");
            Console.WriteLine($"Введіть логін:");

            if (usLgPs.usLogin == Console.ReadLine())
            {
                pass++;
            }
            Console.WriteLine($"Введіть пароль:");
            if (usLgPs.usPass == Console.ReadLine());
            {
                pass++;
            }

            if (pass == 2)
            {
                Console.WriteLine($"{Environment.NewLine}" +
                $"Інформація користувача:{Environment.NewLine}" +
                $"{usNmMl}{Environment.NewLine}" +
                $"{usLgPs}{Environment.NewLine}");
            }
            else 
            {
                Console.WriteLine("Неправельний логін або пароль!");
            }
        }
        public static void SingUp()
        {
            UserInfo usNmMl = new UserInfo();
            Autoriz usLgPs = new Autoriz();
            Console.WriteLine($"Реєстрація");
            Console.WriteLine($"Введіть ваше ім'я");
            usNmMl.usName = Console.ReadLine();
            Console.WriteLine($"Введіть вашу пошту");
            usNmMl.usMail = Console.ReadLine();
            Console.WriteLine($"Введіть логін:");
            usLgPs.usLogin = Console.ReadLine();
            Console.WriteLine($"Введіть пароль:");
            usLgPs.usPass = Console.ReadLine();
            
            Console.WriteLine($"{Environment.NewLine}" +
            $"Інформація користувача:{Environment.NewLine}" +
            $"{usNmMl}{Environment.NewLine}" +
            $"{usLgPs}{Environment.NewLine}");
        }
        static void Menu()
        {
            Console.WriteLine($"Оберіть пункт меню:");
            Console.WriteLine($"1.) Авторизуватися;");
            Console.WriteLine($"2.) Зараєструватися;");
            Console.WriteLine($"3.) Завершити роботу;");
            MenuOptions selectedOption =
           (MenuOptions)Convert.ToByte(Console.ReadLine());
            switch (selectedOption)
            {
               case MenuOptions.SingIn:
                    SingIn();
                    Console.ReadLine();
                    break;
                case MenuOptions.SingUp:
                    SingUp();
                    Console.ReadLine();
                    break;
                case MenuOptions.Exit:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            // Підтримка кириличних символів
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Menu();
            }
        }
    }
}