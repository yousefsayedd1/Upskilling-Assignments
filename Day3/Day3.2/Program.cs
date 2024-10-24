namespace Day3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cashing<int,int> hashing = new Cashing<int,int>();
            hashing.Add(1, 2);
            hashing.Add(3, 4);
            hashing.Add(5, 6);
            hashing.Retrieve(3);
            hashing.Retrieve(8);
            hashing.Retrieve(1);
            hashing.Remove(1);
            hashing.Add(7, 8);
            hashing.Add(9 , 10);
            hashing.Add(10 , 11);
            hashing.Add(12, 13);


        }
    }
}
