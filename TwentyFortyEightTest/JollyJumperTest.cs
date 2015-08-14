using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JollyJumpers;

namespace TwentyFortyEightTest
{
    class JollyJumperTest
    {
        [TestCase(new int[] {1,4,2,3 }, true, TestName = "Example 1")]
        [TestCase(new int[] {5, 1, 4, 2, 3 }, true, TestName = "Example 2")]
        [TestCase(new int[] {3}, true, TestName = "single number")]
        [TestCase(new int[] { 3,7,7,8 }, false, TestName = "false example 1")]
        public void testJollyJumperCheck(int[] input, bool expected)
        {
            Assert.That(JollyJumpers.JollyJumperChecker.isJollyJumper(input), Is.EqualTo(expected));
        }


    }
}
