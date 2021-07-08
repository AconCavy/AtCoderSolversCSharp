using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class AVTests
    {
        const int TimeLimit = 2000;
        const double RelativeError = 1e-9;

        [TestMethod, Timeout(TimeLimit)]
        public void Test1()
        {
            const string input = @"4 3
4 3
9 5
15 8
8 6
";
            const string output = @"21
";
            Tester.InOutTest(Tasks.AV.Solve, input, output);
        }

        [TestMethod, Timeout(TimeLimit)]
        public void Test2()
        {
            const string input = @"2 2
7 6
3 2
";
            const string output = @"8
";
            Tester.InOutTest(Tasks.AV.Solve, input, output);
        }

        [TestMethod, Timeout(TimeLimit)]
        public void Test3()
        {
            const string input = @"10 12
987753612 748826789
36950727 36005047
961239509 808587458
905633062 623962559
940964276 685396947
959540552 928301562
60467784 37828572
953685176 482123245
87983282 66762644
912605260 709048491
";
            const string output = @"6437530406
";
            Tester.InOutTest(Tasks.AV.Solve, input, output);
        }
    }
}
