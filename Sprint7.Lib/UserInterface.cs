using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint7.Lib
{
    public class UserInterface
    {
        FileIO fio;
        CSV table;
        public UserInterface(FileIO fio)
        {
            this.fio = fio;
            this.table = new CSV();
        }
        /*Switcher:
           -1: Halting

            0: Reading from file
            1: Writing to file

            2: Adding line to table
            3: Removing line from table
            4: Printing from table to console
            
            5: Searching in current table
            6: Sorting by i-th element
            
            7: Counting number of elements
            8: Summation of rows by i-th element
            9: Finding mean of i-th element
           10: Finding min of i-th element
           11: Finding max of i-th element
         */
        public void Switcher()
        {
            int errCode = 0;
            while (errCode == 0)
            {
                string foo = Console.ReadLine();
                foo.Append(' ');
                int i = foo.IndexOf(' ');
                string[] bar = new string[2];
                bar[0] = foo.Substring(0, i);
                bar[1] = foo.Substring(i + 1);
                switch (bar[0])
                {
                    case "stop":
                        errCode = -1; break;
                    case "read":
                        table = fio.FileInput(bar[1]);
                        break;
                    case "write":
                        fio.FileWrite(bar[1], table);
                        break;
                    case "add":
                        table.data.Add(bar[1]);
                        break;
                    case "remove":
                        i = int.Parse(bar[1]);
                        table.data.RemoveAt(i);
                        break;
                    case "print":
                        if (bar[1] == "all")
                        {
                            foreach (string s in table.data)
                            {
                                Console.WriteLine(s);
                            }
                        }
                        else
                        {
                            i = int.Parse(bar[1]);
                            Console.WriteLine(table.data[i]);
                        }
                        break;
                    case "search":
                        DataService.Search(table, bar[1]);
                        break;
                    case "sort":
                        i = int.Parse(bar[1]);
                        table.data = DataService.SortByElement(table.data, i);
                        break;
                    case "count":
                        Console.WriteLine(table.data.Count);
                        break;
                    case "sum":
                        i = int.Parse(bar[1]);
                        Console.WriteLine(DataService.Summator(table, i));
                        break;
                    case "mean":
                        i = int.Parse(bar[1]);
                        double res = DataService.Summator(table, i) / table.data.Count;
                        Console.WriteLine(res);
                        break;
                    case "min":
                        i = int.Parse(bar[1]);
                        int min, max;
                        (min, max) = DataService.MinMax(table, i);
                        Console.WriteLine(min);
                        break;
                    case "max":
                        i = int.Parse(bar[1]);
                        (min, max) = DataService.MinMax(table, i);
                        Console.WriteLine(max);
                        break;
                }
            }
        }

    }
}
