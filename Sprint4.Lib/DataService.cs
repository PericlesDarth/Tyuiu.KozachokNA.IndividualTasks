namespace Sprint4.Lib
{
    public class DataService
    {
        public (int, string[]) MultiplyEvens()
        {
            int res = 1;
            int[,] nums = new int[5, 3];
            string str = "382976421897948";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    nums[i, j] = int.Parse(Convert.ToString(str[i * 3 + j]));
                    if (nums[i, j] % 2 == 0)
                    {
                        res *= nums[i, j];
                    }
                }
            }
            string[] foo = new string[5];
            string bar;
            for (int i = 0; i < 5; i++)
            {
                bar = "";
                for (int j = 0; j < 3; j++)
                {
                    if (j == 2)
                    {
                        bar += Convert.ToString(nums[i, j]);
                    }
                    else
                    {
                        bar += Convert.ToString(nums[i, j]) + ", ";
                    }
                    foo[i] = bar;
                }
            }
            return (res, foo);
        }
    }
}
