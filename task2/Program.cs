using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String line;
            List<int> listInt = new List<int>();
            try
            {
                StreamReader sr = new StreamReader(Console.ReadLine());
                line = sr.ReadLine();
                while (line != null)
                {
                    listInt.Add(int.Parse(line));
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            var a = listInt.ToArray();
            Array.Sort(a);
            var max = a[a.Length / 2];
            var count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                count += Math.Abs(max - a[i]);
            }
            Console.WriteLine(count);
        }
    }
}
