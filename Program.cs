namespace Student_Management_System;

class Program
{
    static void Main(string[] args)
    {
        User[] users = null;
        School school = null;
        Console.WriteLine("Welcome to NKENTECH SCHOOL MANAGEMENT SYSTEM");
        bool ctrl_loop = true;
        while (ctrl_loop)
        {
            Console.WriteLine("To register Press 1");
            Console.WriteLine("Already have an account press 2");
            Console.WriteLine("0 to exit\n------------------------------------");
            Console.Write("Input Option: ");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    school = new School();
                    school.Users = new User[4];
                    Console.Write("Name of School: ");
                    school.Name = Console.ReadLine();
                    User principal = new User();
                    Console.Write("Principal's First Name: ");
                    principal.FirstName = Console.ReadLine();
                    Console.Write("Principal's Last Name: ");
                    principal.LastName = Console.ReadLine();
                    Console.Write("Principal's Date of Birth: ");
                    principal.BirthDate = DateTime.Parse(Console.ReadLine());
                    principal.Role = Convert.ToString(Roles.PRINCIPAL);
                    Console.WriteLine($"Welcome {principal.FirstName} {principal.LastName} of {school.Name}\n" +
                                      $"Please provide your login details below");
                    Console.Write("Enter email: ");
                    principal.Email = Console.ReadLine();
                    Console.Write("Enter password: ");
                    principal.Password = Console.ReadLine();
                    school.Users[0] = principal;
                    break;
                case 2:
                    Console.WriteLine("Provide Login Credentials\n------------------------");
                    Console.Write("Username(email): ");
                    string email = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();
                    foreach (User user in school.Users )
                    {
                        if (email.Equals(user.Email) && password.Equals(user.Password) && user.Role.Equals(Roles.PRINCIPAL))
                        {
                            Console.WriteLine("1: Register Teacher");
                            Console.WriteLine("2: Register Student");
                            Console.WriteLine("3: Update Student");
                            Console.WriteLine("4: Delete Student");
                        }else if (email.Equals(user.Email) && password.Equals(user.Password) &&
                                  user.Role.Equals(Roles.TEACHER))
                        {
                            
                        }
                        else
                        {
                            Console.WriteLine("Incorrect login credentials");
                        }   
                    }
                    
                    break;
                case 0:
                    Console.WriteLine("Program Exiting: ");
                    ctrl_loop = false;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
                
            }
            
        }
    }
}