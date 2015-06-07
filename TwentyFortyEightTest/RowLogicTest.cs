﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwentyFortyEight;
using NUnit.Framework;

namespace TwentyFortyEightTest
{
    [TestClass]
    public class Test2048
    {
        
       
        [TestCase (new int[] {0,0,4,4}, new int[] {0,0,0,8}, "Should add up adjacent same numbers", TestName="adds adjacent same")]
        [TestCase(new int[] { 0, 4, 0, 4 }, new int[] { 0, 0, 0, 8 }, "Should add up same numbers over 0", TestName="adds same over empty")]
        [TestCase(new int[] { 2, 0, 0, 4 }, new int[] { 0, 0, 2, 4 }, "Should move over 0", TestName="Moves over empty")]
        [TestCase(new int[] { 2, 4, 2, 2 }, new int[] { 0, 2, 4, 4 }, "Should add up same numbers and move over 0", TestName="Adds up same and moves over")]
        public void TestRowLogicCases(int[] before, int[] expected, string description)
        {
            NUnit.Framework.Assert.That(GameLogic.processRow(before), Is.EquivalentTo(expected), description);
        }
    }
}
