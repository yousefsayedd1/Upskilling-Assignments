namespace Upskilling
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        private int _mileage;
        public int Mileage
        {
            get { return _mileage; }
            set
            {
                if (value >= 0) _mileage = value;
                else throw new Exception();
            }
        }
        public int Age { get; set; }
        public Car(int year)
        {
            Year = year;
            Age = DateTime.Now.Year;
        }
        public void Drive(int distance)
        {
            Mileage += distance;
        }
    }
}