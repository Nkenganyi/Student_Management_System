namespace Student_Management_System;

public class Course
{
    private int courseID;
    private string courseName;
    private string courseDescription;
    private double courseMarks;

    public Course()
    {
    }

    public Course(int courseID, string courseName, string courseDescription)
    {
        this.courseID = courseID;
        this.courseName = courseName;
        this.courseDescription = courseDescription;
        this.courseMarks = 0;
    }

    public int CourseId
    {
        get => courseID;
        set => courseID = value;
    }

    public string CourseName
    {
        get => courseName;
        set => courseName = value ;
    }

    public string CourseDescription
    {
        get => courseDescription;
        set => courseDescription = value;
    }

    public double CourseMarks
    {
        get => courseMarks;
        set => courseMarks = value;
    }
    
}