namespace VehicleNamespace
{
    public class Car
    {
        public string Brand;
        public string Model;
        public int Year;

        public void PrintInfo()
        {
            System.Console.WriteLine($"This is a {Brand} {Model} from {Year}");
        }
    }
}