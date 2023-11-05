using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Practychna1.pract_3;

namespace UnitTestProject
{
    [TestClass]
    public class first_ex_test_abc
    {
        [TestMethod]
        public void Are_equal_27_A()
        {
            var equal = new First_ex(27, 0, 0);
            var test_ans = 1;
            var example_ans = equal.count_of_equal_27();

            Assert.AreEqual(test_ans, example_ans);

        }

        [TestMethod]
        public void Are_equal_27_B()
        {
            var equal = new First_ex(0, 27, 0);
            var test_ans = 1;
            var example_ans = equal.count_of_equal_27();

            Assert.AreEqual(test_ans, example_ans);

        }

        [TestMethod]
        public void Are_equal_27_C()
        {
            var equal = new First_ex(0, 0, 27);
            var test_ans = 1;
            var example_ans = equal.count_of_equal_27();

            Assert.AreEqual(test_ans, example_ans);

        }

        [TestMethod]
        public void Are_equal_27_A_B()
        {
            var equal = new First_ex(27, 27, 0);
            var test_ans = 2;
            var example_ans = equal.count_of_equal_27();

            Assert.AreEqual(test_ans, example_ans);

        }
        [TestMethod]
        public void Are_equal_27_A_B_C()
        {
            var equal = new First_ex(27, 27, 27);
            var test_ans = 3;
            var example_ans = equal.count_of_equal_27();

            Assert.AreEqual(test_ans, example_ans);

        }

        [TestMethod]
        public void Are_equal_27_minus_ABC()
        {
            var equal = new First_ex(-27, -27, -27);
            var test_ans = 3;
            var example_ans = equal.count_of_equal_27();

            Assert.AreEqual(test_ans, example_ans);

        }
    }
}
