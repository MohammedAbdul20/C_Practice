
namespace MyFirstProgram
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bread is ready.");
            Console.WriteLine("Who is the bread for? ");
            string? Name;
            Name = Console.ReadLine();
            Console.WriteLine("Noted: " + Name + " got bread.");
        }
    }
}