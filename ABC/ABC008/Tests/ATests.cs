using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ATests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = @"4 7";
            var output = @"4";
            Tester.InOutTest(() => Tasks.A.Solve(), input, output);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = @"1 1";
            var output = @"1";
            Tester.InOutTest(() => Tasks.A.Solve(), input, output);
        }
    }
}
