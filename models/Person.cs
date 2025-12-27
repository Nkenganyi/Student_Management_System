namespace Student_Management_System;

public abstract class Person
{
    private string firstName;
    private string lastName;
   private DateTime birthDate;
    
    
    
    
    //Properties
    public string FirstName
    {
        get => firstName;
        set => firstName = value;
    }

    public string LastName
    {
        get => lastName;
        set => lastName = value;
    }
    
    public DateTime BirthDate
    {
        get => birthDate;
        set => birthDate = value;
    }
}