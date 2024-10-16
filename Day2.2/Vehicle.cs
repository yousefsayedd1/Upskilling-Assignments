namespace Day2._2
{
    // why abstract class:
    // 1. same domain "Car, Truck and Motorcycle they all Vehicles"
    // 2. shared Method: all Vehicles start and stop in the same way but I give him the option to change it too by making it virtual
    public abstract class Vehicle
    {
        public abstract override string ToString();
        public virtual void Start()
        {
            Console.WriteLine("Vehicle started");
        }
        public virtual void Stop() { Console.WriteLine("Vehicle stopped"); }

    }

}
