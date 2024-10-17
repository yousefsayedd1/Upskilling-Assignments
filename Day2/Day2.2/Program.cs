namespace Day2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = 
            {
            new Car(),
            new Truck(),
            new Motorcycle()
            };
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Start();
                Console.WriteLine(vehicle.ToString()); 
                vehicle.Stop();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }


}
