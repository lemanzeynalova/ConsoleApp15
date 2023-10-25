namespace ConsoleApp15
{
    internal class Program
    {
        static void Main()
            {
                Company company = null;

                while (true)
                {
                    Console.WriteLine("1 - Create a company");
                    Console.WriteLine("2 - Create an employee");
                    Console.WriteLine("3 - Delete employee");
                    Console.WriteLine("4 - Update employee");
                    Console.WriteLine("5 - See all employees");
                    Console.WriteLine("6 - See employee");
                    Console.WriteLine("0 - Exit");

                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter company name: ");
                            string companyName = Console.ReadLine();
                            company = new Company { Name = companyName };
                            break;
                        case 2:
                            if (company != null)
                            {
                                Console.Write("Enter employee name: ");
                                string employeeName = Console.ReadLine();
                                Console.Write("Enter employee surname: ");
                                string employeeSurname = Console.ReadLine();
                                Console.Write("Enter employee age: ");
                                int employeeAge = int.Parse(Console.ReadLine());
                                company.AddUser(new Employee(employeeName, employeeSurname, employeeAge));
                                Console.WriteLine("Employee added to the company.");
                            }
                            else
                            {
                                Console.WriteLine("Please create a company first.");
                            }
                            break;
                        case 3:
                            if (company != null)
                            {
                                Console.Write("Enter the username to delete: ");
                                string usernameToDelete = Console.ReadLine();
                                company.RemoveUser(usernameToDelete);
                            }
                            else
                            {
                                Console.WriteLine("Please create a company first.");
                            }
                            break;
                        case 4:
                            if (company != null)
                            {
                                Console.Write("Enter the username to update: ");
                                string usernameToUpdate = Console.ReadLine();
                                var user = company.GetUser(usernameToUpdate);
                                if (user != null)
                                {
                                    Console.WriteLine("Choose what to update:");
                                    Console.WriteLine("1 - Update Name");
                                    Console.WriteLine("2 - Update Surname");
                                    Console.WriteLine("3 - Update Age");
                                    int updateOption = int.Parse(Console.ReadLine());
                                    Console.Write("Enter the new value: ");
                                    string newValue = Console.ReadLine();
                                    company.UpdateUser(usernameToUpdate, updateOption, newValue);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please create a company first.");
                            }
                            break;
                        case 5:
                            if (company != null)
                            {
                                var employees = company.GetAllUsers();
                                foreach (var employee in employees)
                                {
                                    Console.WriteLine($"Username: {employee.Username}, Name: {employee.Name}, Surname: {employee.Surname}, Age: {employee.Age}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please create a company first.");
                            }
                            break;
                        
                    }
                }
            }
        }
    }
    
