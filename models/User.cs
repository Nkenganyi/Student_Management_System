namespace Student_Management_System;

public class User:Person
{
  private string email;
  private string password;
  private string role;

  public User()
  {
  }

  public User(string email, string password, string role)
  {
    this.email = email;
    this.password = password;
    this.role = role;
  }



  public Student register(User user, Student student)
  {
    if (user.role.Equals(Roles.ADMIN) || user.role.Equals(Roles.MANAGER))
    {
      return student;
    }
    else
    {
      return null;
    }
    
  }

  public Student updateStudent(User user, int studentId, Student[]students)
  {
    if (user.role.Equals(Roles.ADMIN) || user.role.Equals(Roles.MANAGER))
    {
      foreach (Student student in students)
      {
        if (studentId == student.StudentId)
        {
          return student;
        }
      }
    }

    return null;
  }
  
  
  
  
  public string Email
  {
    get => email;
    set => email = value ?? throw new ArgumentNullException(nameof(value));
  }

  public string Password
  {
    get => password;
    set => password = value ?? throw new ArgumentNullException(nameof(value));
  }

  public string Role
  {
    get => role;
    set => role = value ?? throw new ArgumentNullException(nameof(value));
  }
}