namespace Sprint5.Lib
{
    public class DataService
    {
        static string myInput()
        {
            string path = $@"C:\DataSprint5\InPutDataFileTask7V16.txt";

            string res = File.ReadAllText(path);
            return res;
        }
        static void myOutput(string foo)
        {
            string path = $@"C:\DataSprint5\OutPutDataFileTask7V16.txt";
            File.Create(path).Close();

            File.WriteAllText(path, foo);
        }

        public static void FileProcessing()
        {
            string foo = myInput();
            string[] bar = foo.Split(new char[] { ' ' });
            string[] baz = bar;
            int i = 0;

            foreach (string s in bar)
            {
                if (s.Length == 2)
                {
                    baz[i] = "XY";
                }
                i++;
            }
            
            foo = string.Join(" ", baz);

            myOutput(foo);
        }
    }
}
