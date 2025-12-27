namespace Student_Management_System;

public class School
{
    private string name;
    private User[] users;
    private Student[] students;
    private Course[] courses;
    
    public School()
    {}
    
    public School(string name)
    {
        this.name = name;
    }


    public string Name
    {
        get => name;
        set => name = value;
    }

    public User[] Users
    {
        get => users;
        set => users = value;
    }

    public Student[] Students
    {
        get => students;
        set => students = value;
    }

    public Course[] Courses
    {
        get => courses;
        set => courses = value;
    }
    
}