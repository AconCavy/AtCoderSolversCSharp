using Microsoft.VisualStudio.TestTools.UnitTesting;
using A;

namespace Tests
{
    [TestClass]
    public class TestA
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = @"0 2 3 4 5";
            var output = @"1";
            Tester.InOutTest(() => Program.Solve(), input, output);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = @"1 2 0 4 5";
            var output = @"3";
            Tester.InOutTest(() => Program.Solve(), input, output);
        }
    }
}
