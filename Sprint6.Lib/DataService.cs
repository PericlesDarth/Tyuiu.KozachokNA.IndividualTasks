    namespace Sprint6.Lib
{
    public class DataService
    {     
        public (int[,], int) InitializeArray(int n, int m, int n1, int n2)
        {
            int[,] array = new int[n, m];
            int errCode = 0;
            Random rnd = new Random();
            if (n1 <= n2 || n > 1 || m > 1)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (j % 3 == 2)
                        {
                            array[i, j] = (array[i, j - 1] * array[i, j - 1]) - (array[i, j - 2] * array[i, j - 2]);
                        }
                        else
                        {
                            array[i, j] = rnd.Next(n1, n2);
                        }
                    }
                }
            }
            else
            {
                if (n1 > n2)
                {
                    errCode = 1; //Некорректные значения n1 и n2!
                }
                if (m <= 1)
                {
                    errCode = 2; //Слишком мало столбцов!
                }
                if (n <= 1)
                {
                    errCode = 3; //Слишком мало строк!
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        array[i, j] = 0;
                    }
                }
            }
            return (array, errCode);
        }
        
        public (int, int) GetResult(int[,] matrix, int r, int k, int l)
        {
            int res = 1;
            int n, m;
            int errCode = 0;
            n = matrix.GetLength(0);
            m = matrix.GetLength(1);

            if (!( k < l ||
                 r < 0 || r >= n ||
                 k < 0 || k >= m ||
                 l < 0 || l >= m))
            {
                res = -1;

                if (k < l) { errCode = 4; } //Левая граница больше правой!
                if (k < 0 || k >= m) { errCode = 5; } //Некорректная левая граница!
                if (l < 0 || l >= m) { errCode = 6; } //Некорректная правая граница!
                if (r < 0 || r >= n) { errCode = 7; } //Некорректный номер строки!

                return (res, errCode);
            }
            else
            {   
                int i = r;
                for (int j = k; j <= l; j++)
                {
                    if (j%2 == 1)
                    {
                        res *= matrix[i, j];
                    }
                }
            }
            return (res, errCode);
        }
    }
}
