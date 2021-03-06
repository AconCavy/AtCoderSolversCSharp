using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tasks
{
    public class D
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
            var H = new long[N];
            var S = new long[N];
            for (var i = 0; i < N; i++)
            {
                (H[i], S[i]) = Scanner.Scan<long, long>();
            }

            var l = H.Max() - 1;
            var r = (long)1e18;
            while (r - l > 1)
            {
                var m = l + (r - l) / 2;
                var memo = new int[N];
                var ok = true;
                for (var i = 0; i < N; i++)
                {
                    var t = Math.Min(N - 1, (m - H[i]) / S[i]);
                    memo[t]++;
                }

                var sum = 0L;
                for (var i = 0; i < N && ok; i++)
                {
                    sum += memo[i];
                    if (sum > i + 1) ok = false;
                }

                if (ok) r = m;
                else l = m;
            }

            Console.WriteLine(r);
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
        }
    }
}
