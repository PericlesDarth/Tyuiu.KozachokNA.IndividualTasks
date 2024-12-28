using Sprint3.Lib;

namespace ConsoleApp2
{
    internal class Sprint3
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double[] foo = ds.ArrayFunction();
            string bar = "";
            for (int i = -5; i <= 5; i++)
            {
                bar = Convert.ToString(i) + ": " + Convert.ToString(foo[i+5]);
                Console.WriteLine(bar);
            }
        }
    }
}
