using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp15
{
    internal class Employee
    {
        private string name;
        private string surname;
        private string username;
        private int age;

        public string Name
        {
            get => name;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value[0].ToString().ToUpper() + value.Substring(1);
                }
            }
        }
        public string Surname
        {
            get => surname;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    surname = value[0].ToString().ToUpper() + value.Substring(1);
                }
            }
        }
        public string Username
        {
            get => username;
        }
        public int Age
        {
            get => age;
        }
    }
}
    

