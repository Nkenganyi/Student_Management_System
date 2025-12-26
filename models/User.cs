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
  
  public string updateStudentMarks(User user, Student[]students, int studentId, double marks, string courseName)
  {
    string message = null;
    double oldMarks = 0.0;
    if (user.role.Equals(Roles.TEACHER))
    {
      foreach (Student student in students)
      {
        if (studentId == student.StudentId)
        {
          foreach (Course course in student.Courses)
          {
            if (courseName.Equals(course.CourseName))
            {
              oldMarks = course.CourseMarks;
              course.CourseMarks = marks;
              message = $"Marks updated from {oldMarks} to {marks}.";
            }
          }
        }
        else
        {
          message = "Student not found";
        }
      }
    }
    return message;
  }
  
  public string deleteStudent(User user, int studentId, Student[]students)
  {
    string message = null;
    if (user.role.Equals(Roles.ADMIN) || user.role.Equals(Roles.MANAGER))
    {
      for (int i = 0; i < students.Length; i++){
        if (studentId == students[i].StudentId)
        {
          students[i] = null;
          message = "Student deleted successfully";
        }
        else
        {
         message = "Student not found";
        }
      }
    }
    return message;
  }
  
  
  
  public string Email
  {
    get => email;
    set => email = value;
  }

  public string Password
  {
    get => password;
    set => password = value;
  }

  public string Role
  {
    get => role;
    set => role = value;
  }
}