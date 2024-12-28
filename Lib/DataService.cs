namespace Lib
{
    public class DataService
    {
        public bool IsShaded(double x, double y)
        {
            bool result;
            if (y > 0)
            {
                if ((x * x + y * y > 1) && (x * x + y * y < 4))
                {
                    result = true;
                }
                else { result = false; }
            }
            else { result = false; }
            return result;
        }
    }
}
