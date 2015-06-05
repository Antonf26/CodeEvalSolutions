using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwentyFortyEight;


namespace TwentyFortyEightTest
{
    [TestClass]
    public class Test2048
    {
        
        [TestMethod]
        public void TestRowProcessMovesOver0()
        {
            int[] input = new int[4] { 2, 0, 0, 4 };
            int[] expected = new int[4] { 0, 0, 2, 4 };
            CollectionAssert.AreEqual(GameLogic.processRow(input), expected);
        }
        
        [TestMethod]
        public void TestRowProcessAddsUpEquals()
        {
            int[] input = new int[4] { 0, 0, 4, 4 };
            int[] expected = new int[4] { 0, 0, 0, 8};
            CollectionAssert.AreEqual(GameLogic.processRow(input), expected);
        }

        [TestMethod]
        
        public void TestRowProcessAddsUpEqualsAndMovesOver0()
        {
            int[] input = new int[4] { 2, 4, 2, 2 };
            int[] expected = new int[4] { 0, 2, 4, 4 };
            CollectionAssert.AreEqual(GameLogic.processRow(input), expected);
        }
       
        [TestMethod]
        public void TestRowProcessDoesntChangeUnNeeded()
        {
            int[] input = new int[4] { 0, 0, 0, 8 };
            int[] expected = new int[4] { 0, 0, 0, 8 };
            CollectionAssert.AreEqual(GameLogic.processRow(input), expected);
        }


    }
}
