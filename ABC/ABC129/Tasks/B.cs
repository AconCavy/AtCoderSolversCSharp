using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tasks
{
    public class B
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
            var N = Scanner.Scan<int>();
            var W = Scanner.ScanEnumerable<long>().ToArray();
            var cum = CumulativeItems(W).ToArray();
            var answer = (long)1e9;
            for (var i = 1; i < N; i++)
            {
                var l = cum[i] - cum[0];
                var r = cum[N] - cum[i];
                answer = Math.Min(answer, Math.Abs(r - l));
            }

            Console.WriteLine(answer);
        }

        public static IEnumerable<long> CumulativeItems(IEnumerable<long> items)
        {
            var arr = items.ToArray();
            var ret = new long[arr.Length + 1];
            for (var i = 0; i < arr.Length; i++) ret[i + 1] = arr[i] + ret[i];
            return ret;
        }
        public static IEnumerable<long> CumulativeItems(IEnumerable<long> items, long mod)
        {
            var arr = items.ToArray();
            var ret = new long[arr.Length + 1];
            for (var i = 0; i < arr.Length; i++) ret[i + 1] = (arr[i] + ret[i]) % mod;
            return ret;
        }

        public static class Scanner
        {
            private static Queue<string> queue = new Queue<string>();
            public static T Next<T>()
            {
                if (!queue.Any()) foreach (var item in Console.ReadLine().Trim().Split(" ")) queue.Enqueue(item);
                return (T)Convert.ChangeType(queue.Dequeue(), typeof(T));
            }
            public static T Scan<T>() => Next<T>();
            public static (T1, T2) Scan<T1, T2>() => (Next<T1>(), Next<T2>());
            public static (T1, T2, T3) Scan<T1, T2, T3>() => (Next<T1>(), Next<T2>(), Next<T3>());
            public static (T1, T2, T3, T4) Scan<T1, T2, T3, T4>() => (Next<T1>(), Next<T2>(), Next<T3>(), Next<T4>());
            public static (T1, T2, T3, T4, T5) Scan<T1, T2, T3, T4, T5>() => (Next<T1>(), Next<T2>(), Next<T3>(), Next<T4>(), Next<T5>());
            public static IEnumerable<T> ScanEnumerable<T>() => Console.ReadLine().Trim().Split(" ").Select(x => (T)Convert.ChangeType(x, typeof(T)));
        }
    }
}
