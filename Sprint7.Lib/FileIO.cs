using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint7.Lib
{
    public class FileIO
    {
        public CSV FileInput(string path)
        {
            CSV res = new CSV();
            string[] foo = File.ReadAllLines(path);
            foreach (string line in foo)
            {
                res.data.Add(line);
            }
            return res;
        }
        public void FileOutput(string path, CSV table)
        {
            File.Create(path);
            string[] foo = table.data.ToArray();
            File.WriteAllLines(path, foo);
        }
        public void FileWrite(string path, CSV table)
        {
            File.OpenWrite(path);
            string[] foo = table.data.ToArray();
            File.AppendAllLines(path, foo);
        }
    }
}
