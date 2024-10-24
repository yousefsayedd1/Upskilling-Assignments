namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "abc", "jjj", "ssss" };
            int[] numbers = { 1, 2, 3, 4, 5, };
            ArrayUtils.ReverseArray(numbers);
            ArrayUtils.ReverseArray(strings);
            foreach (int i in numbers)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            foreach (string i in strings)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine(ArrayUtils.FindMax(numbers));
            Console.WriteLine(ArrayUtils.FindMax(strings));


        }
    }
}
