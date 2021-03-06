using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace Tasks
{
    public class C
    {
        public static void Main(string[] args)
        {
            var sw = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);
            Solve();
            Console.Out.Flush();
        }

        public static void Solve()
        {
            var N = Scanner.Scan<int>();
            var S = new string[N];
            for (var i = 0; i < N; i++)
            {
                S[i] = Scanner.Scan<string>();
            }

            Array.Sort(S, StringComparer.Ordinal);

            var UV = new (int Idx, bool Good)[N];
            for (var i = 0; i < N; i++)
            {
                var T = Scanner.ScanEnumerable<string>().ToArray();
                var idx = Array.IndexOf(S, T[0]);
                var good = T[3] == "good";
                UV[i] = (idx, good);
            }

            var answer = new List<int>();

            for (var s = 1; s < 1 << N; s++)
            {
                var ok = true;
                var tmp = new List<int>();

                for (var i = 0; i < N; i++)
                {
                    var (idx, good) = UV[i];
                    var b = (s >> idx & 1) == 1;

                    if ((s >> i & 1) == 1)
                    {
                        tmp.Add(i);
                        if (good) ok &= b;
                        else ok &= !b;
                    }
                    else
                    {
                        if (good) ok &= !b;
                        else ok &= b;
                    }
                }

                if (ok)
                {
                    if (answer.Count < tmp.Count) answer = tmp;
                    else if (answer.Count == tmp.Count)
                    {
                        for (var i = 0; i < answer.Count; i++)
                        {
                            var comp = answer[i].CompareTo(tmp[i]);
                            if (comp != 0)
                            {
                                if (comp > 0) answer = tmp;
                                break;
                            }
                        }
                    }
                }
            }

            if (answer.Any())
            {
                foreach (var idx in answer)
                {
                    Console.WriteLine(S[idx]);
                }
            }
            else
            {
                Console.WriteLine("No answers");
            }
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
            public static (T1, T2, T3, T4, T5, T6) Scan<T1, T2, T3, T4, T5, T6>() => (Next<T1>(), Next<T2>(), Next<T3>(), Next<T4>(), Next<T5>(), Next<T6>());
            public static IEnumerable<T> ScanEnumerable<T>() => Console.ReadLine().Trim().Split(" ").Select(x => (T)Convert.ChangeType(x, typeof(T)));
        }
    }
}
