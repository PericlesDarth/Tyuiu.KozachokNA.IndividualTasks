using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint7.Lib
{
    public class DataService
    {
        public static CSV Search(CSV table, string searchFor)
        {
            CSV res = new CSV();
            foreach (var item in table.data) {
                if (item.IndexOf(searchFor) != -1)
                {
                    res.data.Add(item);
                }
            }
            return res;
        }
        public static string ithElement (string s, int index)
        {
            string[] tmp = s.Split(';');
            return tmp[index];
        }
        public static List<string> SortByElement(List<string> data, int i)
        {
            int len = data.Count;
            List<string> left, right;
            left = new List<string>();
            right = new List<string>();
            if (len > 1)
            {
                int j;
                for (j = 0; j < len / 2; j++)
                {
                    left.Add(data[j]);
                }
                for (j = 0; j < (len - len / 2); j++)
                {
                    right.Add(data[len / 2 + j]);
                }

                left = SortByElement(left, i);
                right = SortByElement(right, i);

                List<string> newData = new List<string>();
                int leftIndex, rightIndex;
                leftIndex = 0;
                rightIndex = 0;
                string foo, bar;

                while (leftIndex + rightIndex < left.Count + right.Count)
                {
                    if (leftIndex < left.Count && rightIndex < right.Count)
                    {
                        foo = ithElement(left[leftIndex], i);
                        bar = ithElement(right[rightIndex], i);
                        if (foo.CompareTo(bar) < 0)
                        {
                            newData.Add(left[leftIndex]);
                            leftIndex++;
                        }
                        else
                        {
                            newData.Add(right[rightIndex]);
                            rightIndex++;
                        }
                    }
                    else
                    {
                        if (leftIndex < left.Count)
                        {
                            newData.Add(left[leftIndex]);
                            leftIndex++;
                        }
                        else
                        {
                            newData.Add(right[rightIndex]);
                            rightIndex++;
                        }
                    }
                }
                return newData;
            }
            else
            {
                return data;
            }
        }

        public static int Summator(CSV table, int i)
        {
            int sum = 0;
            foreach (var row in table.data)
            {
                sum += int.Parse(ithElement(row, i));
            }
            return sum;
        }

        public static (int, int) MinMax(CSV table, int i)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            string foo;
            int bar;
            foreach (var row in table.data)
            {
                foo = ithElement(row, i);
                bar = int.Parse(foo);
                if (bar > max)
                {
                    max = bar;
                }
                if (bar < min)
                {
                    min = bar;
                }
            }
            return (min, max);
        }
    }
}
