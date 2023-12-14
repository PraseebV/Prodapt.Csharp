namespace Prodapt.GitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var today=DateTime.Now;
            Console.WriteLine($"Today:{today}");
            Console.WriteLine($"Date Only:{today.ToShortDateString}");
            Console.WriteLine($"Date Only:{DateTime.Now}");
        }
    }
}
