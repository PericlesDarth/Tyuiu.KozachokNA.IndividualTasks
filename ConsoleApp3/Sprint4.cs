using Sprint4.Lib;

namespace ConsoleApp3
{
    internal class Sprint4
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int foo;
            string[] bar;
            (foo, bar) = ds.MultiplyEvens();
            foreach (string s in bar)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine("Product of even numbers in that string is " + Convert.ToString(foo));
        }
    }
}
