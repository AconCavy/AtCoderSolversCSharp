using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class DTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = @"3 10
15 9
10 6
6 4";
            var output = @"16";
            Tester.InOutTest(() => Tasks.D.Solve(), input, output);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = @"30 499887702
128990795 137274936
575374246 989051853
471048785 85168425
640066776 856699603
819841327 611065509
704171581 22345022
536108301 678298936
119980848 616908153
117241527 28801762
325850062 478675378
623319578 706900574
998395208 738510039
475707585 135746508
863910036 599020879
340559411 738084616
122579234 545330137
696368935 86797589
665665204 592749599
958833732 401229830
371084424 523386474
463433600 5310725
210508742 907821957
685281136 565237085
619500108 730556272
88215377 310581512
558193168 136966252
475268130 132739489
303022740 12425915
122379996 137199296
304092766 23505143";
            var output = @"3673016420";
            Tester.InOutTest(() => Tasks.D.Solve(), input, output);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var input = @"10 2921
981421680 325
515936168 845
17309336 371
788067075 112
104855562 96
494541604 960
32007355 161
772339969 581
55112800 248
98577050 22";
            var output = @"3657162058";
            Tester.InOutTest(() => Tasks.D.Solve(), input, output);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var input = @"10 936447862
854 810169801
691 957981784
294 687140254
333 932608409
832 42367415
642 727293784
139 870916042
101 685539955
853 243593312
369 977358410";
            var output = @"1686";
            Tester.InOutTest(() => Tasks.D.Solve(), input, output);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var input = @"30 99999999
1001 1
1 1001
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1
1 1";
            var output = @"1030";
            Tester.InOutTest(() => Tasks.D.Solve(), input, output);
        }
    }
}
