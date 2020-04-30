using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace A
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sw = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);
            Solve();
            Console.Out.Flush();
        }

        public static void Solve()
        {
            var ap = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine((int)(ap[0] * 3 + ap[1]) / 2);
        }
    }
}
