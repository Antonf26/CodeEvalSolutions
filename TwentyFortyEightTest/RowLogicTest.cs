
using TwentyFortyEight;
using NUnit.Framework;

namespace TwentyFortyEightTest
{
 
    public class Test2048
    {
        
       
        [TestCase (new int[] {0,0,4,4}, new int[] {0,0,0,8}, "Should add up adjacent same numbers", TestName="adds adjacent same")]
        [TestCase(new int[] { 0, 4, 0, 4 }, new int[] { 0, 0, 0, 8 }, "Should add up same numbers over 0", TestName="adds same over empty")]
        [TestCase(new int[] { 2, 0, 0, 4 }, new int[] { 0, 0, 2, 4 }, "Should move over 0", TestName="Moves over empty")]
        [TestCase(new int[] { 2, 4, 2, 2 }, new int[] { 0, 2, 4, 4 }, "Should add up same numbers and move over 0", TestName="Adds up same and moves over")]
        [TestCase(new int[] { 2,2,4,2}, new int[] {0,4,4,2}, "Shouldn't add twice", TestName="Shouldn't add twice")]
        public void TestRowLogicCases(int[] before, int[] expected, string description)
        {
            NUnit.Framework.Assert.That(GameLogic.processRow(before), Is.EquivalentTo(expected), description);
        }

        [TestCase("RIGHT; 4; 4 0 2 0|0 0 0 8|4 0 2 4|2 4 2 2", "0 0 4 2|0 0 0 8|0 4 2 4|0 2 4 4", TestName="Example right")]
        [TestCase("UP; 4; 2 0 2 0|0 2 0 4|2 8 0 8|0 8 0 16", "4 2 2 4|0 16 0 8|0 0 0 16|0 0 0 0", TestName = "Example up")]
        [TestCase("DOWN; 5; 0 2 0 4 16|0 2 4 8 8|2 4 8 0 0|0 16 0 4 2|4 0 8 16 0", "0 0 0 0 0|0 0 0 4 0|0 4 0 8 16|2 4 4 4 8|4 16 16 16 2", TestName = "Test Down")]
        [TestCase("LEFT; 5; 0 2 0 4 16|0 2 4 8 8|2 4 8 0 0|0 16 0 4 2|4 0 8 16 0", "2 4 16 0 0|2 4 16 0 0|2 4 8 0 0|16 4 2 0 0|4 8 16 0 0", TestName = "Test Left")]
        public void TestInputOutput(string input, string expected)
        {
            NUnit.Framework.Assert.That(GameLogic.processLine(input), Is.EqualTo(expected));
        }
    }
}
