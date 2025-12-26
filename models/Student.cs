namespace Student_Management_System;

public class Student: Person
{
    private int studentID;
    private Course[] courses;
    
    public Student(){}
    
    public Student(int studentId, Course[] courses)
    {
        studentID = studentId;
        this.courses = courses;
    }

    public int StudentId
    {
        get => studentID;
        set => studentID = value;
    }

    public Course[] Courses
    {
        get => courses;
        set => courses = value;
    }
}