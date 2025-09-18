namespace TorsdagExercise;

public class Animal
{
    public string Type;
    public string Sound;

    public void MakeSound()
    {
        Console.WriteLine($"This is a {Type} and it goes {Sound}!");
    }
}