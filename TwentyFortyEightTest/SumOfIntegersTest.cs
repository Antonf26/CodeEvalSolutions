using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SumOfIntegers;

namespace TwentyFortyEightTest
{
    class SumOfIntegersTest
    {
        [TestCase("-10,2,3,-2,0,5,-15", 8, TestName="CodeEval first example")]
        [TestCase("2,3,-2,-1,10", 12, TestName="CodeEval second example")]
        public void TestSumOfIntgers(string input, int expected)
        {
            Assert.That(SumOfIntegers.SumOfIntegers.GetHighestSum(input), Is.EqualTo(expected));
        }
    }
}
