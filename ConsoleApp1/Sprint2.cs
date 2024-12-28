using Lib;

namespace ConsoleApp1
{
    internal class Sprint2
    {
        static void Main(string[] args)
        {
            double foo, bar;
            DataService ds = new DataService();
            foo = Convert.ToDouble(Console.ReadLine());
            bar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ds.IsShaded(foo, bar));
        }
    }
}
