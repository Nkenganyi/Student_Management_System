namespace Student_Management_System;

class Program
{
    static void Main(string[] args)
    {
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
                    School school = new School();
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
                    
                    
                    break;
                case 2:
                    Console.WriteLine("Login: ");
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