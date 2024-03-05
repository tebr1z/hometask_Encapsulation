using System;
using System.Linq;
using System.Xml;

namespace ConsoleApp27
{
    internal class User
    {
        private string _UserName;
        private int _Age;
        private string _Password;
       
        public string Username
        {
            get
            {
                return _UserName;
            }


            set
            {
                _UserName = value;
            }
        }

        
        public int Age
        {
            get {
                   return _Age;
                }
            set
            {
                

                if (value < 0)
                {
                    Console.WriteLine(" yashda - Ola bilmez");
                    
                }
               
                _Age = value;
            }
        }

        public string Password
        {
            get { return _Password; }
            set
            {
                if (value == null || value.Length == 0 )
                {
                    Console.WriteLine("Sifre bosh ola bilmez");
                    return;
                }

                if (value.Length < 8)
                {
                    Console.WriteLine("Sifre en 8 Karakter uzunluquda olamlidir");
                    return;
                }

                bool hasUppercase = false;
                bool hasDigit = false;

                foreach (char c in value)
                {
                    if (char.IsUpper(c))
                    {
                        hasUppercase = true;
                    }
                    else if (char.IsDigit(c))
                    {
                        hasDigit = true;
                    }
                }

                if (!hasUppercase)
                {
                    Console.WriteLine("Sifre en az bir boyuk reqem olmalidir");
                    return;
                }

                if (!hasDigit)
                {
                    Console.WriteLine("Sifre en az bir reqem olamlidir");
                    return;
                }

                _Password = value;
            }
        }


    }
}
