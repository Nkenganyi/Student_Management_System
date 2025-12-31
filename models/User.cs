namespace Student_Management_System;

public class User : Person
{
    private string email;
    private string password;
    private Roles role;

    public User()
    {
    }

    public User(string email, string password, Roles role)
    {
        this.email = email;
        this.password = password;
        this.role = role;
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

    public Roles Role
    {
        get => role;
        set => role = value;
    }


    public Student register(Student student)
    {
        return student;
    }

    public Student updateStudent(int studentId, Student[] students)
    {
        foreach (Student student in students)
        {
            if (studentId == student.StudentId)
            {
                return student;
            }
        }

        return null;
    }

    public string updateStudentMarks(Student[] students, int studentId, double marks, string courseName)
    {
        string message = null;
        double oldMarks = 0.0;
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

        return message;
    }

    public string deleteStudent(int studentId, Student[] students)
    {
        string message = null;
        for (int i = 0; i < students.Length; i++)
        {
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

        return message;
    }
}