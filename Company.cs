using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Company
    {

        public string Name { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public void AddUser(Employee employee)
        {
            Employees.Add(employee);
        }

        public void RemoveUser(string username)
        {
            var userToRemove = Employees.Find(e => e.Username == username);
            if (userToRemove != null)
            {
                Employees.Remove(userToRemove);
                Console.WriteLine($"{username} is removed from the company.");
            }
            else
            {
                Console.WriteLine($"{username} does not exist in the company.");
            }
        }

        public Employee GetUser(string username)
        {
            var user = Employees.Find(e => e.Username == username);
            if (user != null)
            {
                return user;
            }
            else
            {
                Console.WriteLine($"{username} does not exist in the company.");
                return null;
            }
        }

        public List<Employee> GetAllUsers()
        {
            return Employees;
        }
        public void UpdateUser(string username, int option, string newValue)
        {
            var user = GetUser(username);
            if (user != null)
            {
                switch (option)
                {
                    case 1:
                        user.UpdateName(newValue);
                        break;
                    case 2:
                        user.UpdateSurname(newValue);
                        break;
                    case 3:
                        if (int.TryParse(newValue, out int newAge) && newAge >= 0)
                        {
                            user.UpdateAge(newAge);
                        }
                        else
                        {
                            Console.WriteLine("Invalid age input. Age should be a non-negative integer.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose 1 for Name, 2 for Surname, or 3 for Age.");
                        break;
                }
            }
        }
    }
}

