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
            Console.WriteLine("1: REGISTER");
            Console.WriteLine("1: LOGIN");
            Console.WriteLine("0: EXIT\n------------------------------------");
            Console.Write("Input Option: ");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    school = new School();
                    school.Users = new User[4];
                    school.Students = new Student[10];
                    school.Courses = new Course[3];
                    Console.Write("Name of School: ");
                    school.Name = Console.ReadLine();
                    User principal = new User();
                    Console.Write("Principal's First Name: ");
                    principal.FirstName = Console.ReadLine();
                    Console.Write("Principal's Last Name: ");
                    principal.LastName = Console.ReadLine();
                    Console.Write("Principal's Date of Birth (mm/dd/yyyy): ");
                    principal.BirthDate = DateTime.Parse(Console.ReadLine());
                    principal.Role = Roles.PRINCIPAL;
                    Console.WriteLine($"Welcome {principal.FirstName} {principal.LastName} of {school.Name}\n" +
                                      $"Please provide your login details below");
                    Console.Write("Enter email: ");
                    principal.Email = Console.ReadLine();
                    Console.Write("Enter password: ");
                    principal.Password = Console.ReadLine();
                    school.Users[0] = principal;
                    Console.WriteLine(school.Users[0].Role);
                    break;
                case 2:
                    if (school == null || school.Users == null)
                    {
                        Console.WriteLine("No registered users found.");
                        break;
                    }

                    Console.WriteLine("Provide Login Credentials\n------------------------");
                    Console.Write("Username(email): ");
                    string e = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string p = Console.ReadLine();

                    bool isAuthenticated = false;

                    foreach (User u in school.Users)
                    {
                        if (u == null) continue;

                        if (e == u.Email && p == u.Password)
                        {
                            isAuthenticated = true;
                            if (u.Role == Roles.PRINCIPAL || u.Role == Roles.ADMIN)
                            {
                                while (isAuthenticated)
                                {
                                    Console.WriteLine("1: Register Teacher");
                                    Console.WriteLine("2: Register Student");
                                    Console.WriteLine("3: Update Student");
                                    Console.WriteLine("4: Delete Student");
                                    Console.WriteLine("0: to logout");
                                    Console.Write("choose option: ");
                                    int pOption = Convert.ToInt32(Console.ReadLine());
                                    switch (pOption)
                                    {
                                        case 0:
                                            isAuthenticated = false;
                                            break;
                                        case 1:
                                            User teacher = new User();
                                            Console.Write("Teacher's First Name: ");
                                            teacher.FirstName = Console.ReadLine();
                                            Console.Write("Teacher's Last Name: ");
                                            teacher.LastName = Console.ReadLine();
                                            Console.Write("Teacher's Date of Birth (mm/dd/yyyy): ");
                                            teacher.BirthDate = DateTime.Parse(Console.ReadLine());
                                            Console.WriteLine("Choose a Role for the user \n" +
                                                              "1: TEACHER\n" +
                                                              "2: ADMIN");
                                            int roles = Convert.ToInt32(Console.ReadLine());
                                            if (roles == 1)
                                            {
                                                teacher.Role = Roles.TEACHER;
                                            }
                                            else if (roles == 2)
                                            {
                                                teacher.Role = Roles.ADMIN;
                                            }

                                            Console.WriteLine("Provide Login credentials \n" +
                                                              " ---------------------------------------------");
                                            Console.Write("Username(email): ");
                                            teacher.Email = Console.ReadLine();
                                            Console.Write("Enter Password: ");
                                            teacher.Password = Console.ReadLine();
                                            for (int i = 0; i < school.Users.Length; i++)
                                            {
                                                if (school.Users[i] != null) continue;

                                                if (school.Users[i] == null)
                                                {
                                                    school.Users[i] = teacher;
                                                    i = school.Users.Length + 1;
                                                }
                                            }

                                            break;
                                        case 2:
                                            break;
                                        case 3:
                                            break;
                                        case 4:
                                            break;
                                    }
                                }

                                isAuthenticated = true;
                            }
                            else if (u.Role == Roles.TEACHER)
                            {
                                Console.WriteLine("1: Update Student Marks");
                                Console.WriteLine("0: To Logout");
                                int toptions = Convert.ToInt32(Console.ReadLine());
                                if (toptions == 1)
                                {
                                    Console.WriteLine("Enter Student ID: ");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter Course Name: ");
                                    string courseName = Console.ReadLine();
                                    Console.WriteLine("Enter New Marks: ");
                                    double marks = Convert.ToDouble(Console.ReadLine());

                                    u.updateStudentMarks(school.Students, id, marks,
                                        courseName);
                                }
                            }

                            break; //stop searching once found
                        }
                    }

                    if (!isAuthenticated)
                    {
                        Console.WriteLine("Incorrect login credentials");
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
        } //while loop
    } //main method
}