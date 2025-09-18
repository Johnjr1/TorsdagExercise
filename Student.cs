namespace TorsdagExercise;

public class Student : Person
{
    public string StudentID;

    public void PrintStudentInfo()
    {
        Console.WriteLine($"Student Name: {Name}, Age: {Age}, Student ID: {StudentID}");
    }
}


