namespace Sprint3.Lib
{
    public class DataService
    {
        public double[] ArrayFunction() 
        {
            double[] array = new double[11];
            int x;
            for (int i = 0; i < array.Length; i++)
            {
                x = i - 5;
                if (! (x == 0.4))
                {
                    array[i] = Math.Round(Math.Cos(x) / (x - 0.4) + Math.Sin(x) * 8 * x + 2, 2);
                }
                else
                {
                    array[i] = 0;
                }
            }
            return array;
        }
    }
}
