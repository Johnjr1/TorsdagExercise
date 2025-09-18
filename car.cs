namespace TorsdagExercise
{

    // Car class definition
    public class Car
    {
        public string Brand;
        public string Model;
        public int Year;

        // Method to print car information
        public void PrintInfo()
        {
            System.Console.WriteLine($"This is a {Brand} {Model} from {Year}");
        }
    }
    
}