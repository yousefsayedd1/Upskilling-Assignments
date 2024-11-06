namespace Day6._2
{
    internal class Program
    {
        static private Employee CaptureEmployeeData()
        {
            string name;
            int yearsOfExperience;
            double salary;
            Console.Write("Enter Employee Name: ");
            name = Console.ReadLine();
            bool isValidYearsOfExperience = true;
            do
            {
                if (!isValidYearsOfExperience) Console.WriteLine("Invalid input try again");
                Console.Write("Enter Employee Years Of Experience: ");
                isValidYearsOfExperience = int.TryParse(Console.ReadLine(), out yearsOfExperience);
            }
            while (!isValidYearsOfExperience);

            bool isValidSalary = true;
            do
            {
                if (!isValidSalary) Console.WriteLine("Invalid input try again");
                Console.Write("Enter Employee Salary: ");
                isValidSalary = double.TryParse(Console.ReadLine(), out salary);
            }
            while (!isValidSalary);

            return new Employee(name, yearsOfExperience, salary);
        }
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();

            while (true)
            {
                Employee customer = CaptureEmployeeData();
                Employees.Add(customer);
                Console.WriteLine("wanna add another Employee? Y for Yes and N for No");
                if (Console.ReadLine()?.ToUpperInvariant() != "Y") break;
            }

            List<Employee> SortedBySalary = SortEmployees(Employees, (Employee1, Employee2) =>
            {
                if (Employee1.Salary < Employee2.Salary) return -1;
                else if (Employee1.Salary > Employee2.Salary) return 1;
                return 0;
            });
            List<Employee> SortedByExperience = SortEmployees(Employees, (Employee1, Employee2) =>
            {
                if (Employee1.YearsOfExperience < Employee2.YearsOfExperience) return -1;
                else if (Employee1.YearsOfExperience > Employee2.YearsOfExperience) return 1;
                return 0;
            });

            foreach (Employee employee in SortedBySalary)
            {
                Console.WriteLine(employee.ToString());
            }
            foreach (Employee employee in SortedByExperience)
            {
                Console.WriteLine(employee.ToString());
            }

            CalculateBonus(Employees, (employee) => employee.Salary * ((employee.YearsOfExperience / (double)10)));
        }
        static List<Employee> SortEmployees(List<Employee> employees, Func<Employee, Employee, int> comparison)
        {
            List<Employee> employeesCopy = new List<Employee>(employees);
            employeesCopy.Sort(new Comparison<Employee>(comparison));
            return employeesCopy;
        }
        static void CalculateBonus(List<Employee> employees, Func<Employee, double> bonusCalculator)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.ToString()} bonus = {bonusCalculator(employee)}");
            }
        }
        public class Employee
        {
            public string Name { get; set; }
            public int YearsOfExperience { get; set; }
            public double Salary { get; set; }
            public Employee(string name, int yearsOfExperience, double salary)
            {
                Name = name;
                YearsOfExperience = yearsOfExperience;
                Salary = salary;
            }
            public override string ToString()
            {
                return $"{Name} {YearsOfExperience} {Salary}";
            }
        }
    }
}
