namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random rnd = new Random();
            int rNum = rnd.Next(0, 101);
            Console.WriteLine(rNum);
        }
    }
}