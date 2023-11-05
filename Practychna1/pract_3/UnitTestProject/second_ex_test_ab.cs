using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Practychna1.pract_3;

namespace UnitTestProject
{
    [TestClass]
    public class second_ex_test_ab
    {
        [TestMethod]
        public void sum_A_B_1_103()
        {
            Second_ex examp = new Second_ex(1, 103);
            var test_ans = 136;
            var examp_ans = examp.sum();

            Assert.AreEqual(examp_ans, test_ans);
        }

        [TestMethod]
        public void sum_A_B_0_0()
        {
            Second_ex examp = new Second_ex(0, 0);
            var test_ans = 0;
            var examp_ans = examp.sum();

            Assert.AreEqual(examp_ans, test_ans);
        }

        [TestMethod]
        public void sum_A_B_minus_103_plus_103()
        {
            Second_ex examp = new Second_ex(-103, 103);
            var test_ans = 136;
            var examp_ans = examp.sum();

            Assert.AreEqual(examp_ans, test_ans);
        }

        [TestMethod]
        public void sum_A_great_B_103_1_error()
        {
            Second_ex examp = new Second_ex(103, 1);
         
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => examp.sum());
        }
    }
}
