namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random rnd = new Random();
            int rNumber = rnd.Next(0, 101);
            Console.WriteLine(rNumber);
        }
    }
}