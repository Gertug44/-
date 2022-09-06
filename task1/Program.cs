using System;
using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static string GenerateString(int n, double m)
        {
            var a = new StringBuilder();
            var count = Math.Ceiling(m / n);
            for (int i = 0; i < count; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    a.Append(j.ToString());
                }
            }
            return a.ToString();
        }
        static void Main(string[] args)
        {
            int n;
            int m;
            var arg = Console.ReadLine().Trim().Split(" ");
            int last = 0;
            var path = new StringBuilder();
            var str = "";
            if (arg.Length < 2)
                throw new Exception();
            try
            {
                n = int.Parse(arg[0]);
                m = int.Parse(arg[1]);
            }
            catch
            {
                throw new Exception();
            }
            while (last != 1)
            {
                str += GenerateString(n, m);
                var substr = str.Substring(0, m);
                str = str.Remove(0, m - 1);
                last = int.Parse(substr.Substring(substr.Length - 1));
                path.Append(substr[0]);
            }

            Console.WriteLine(path);
        }
    }
}
