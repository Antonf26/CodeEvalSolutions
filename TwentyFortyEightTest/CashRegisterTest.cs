using NUnit.Framework;
using CashRegister;

namespace TwentyFortyEightTest
{
    class CashRegisterTest
    {
        [TestCase(12.57, 12.57, "ZERO", TestName = "Returns ZERO for equal values")]
        [TestCase(13.57, 10.57, "ERROR", TestName = "Returns ERROR for equal values")]
        public void TestNonCalculated(decimal price, decimal cash, string returned)
        {
            Assert.That(Register.GetChangeString(price, cash), Is.EqualTo(returned));
        }

        [TestCase(15.94, 16.00, "NICKEL,PENNY", TestName = "Returns multiple denominations")]
        [TestCase(45, 50, "FIVE", TestName = "Returns single denomination")]
        public void TestCalculated(decimal price, decimal cash, string returned)
        {
            Assert.That(Register.GetChangeString(price, cash), Is.EqualTo(returned));

        }
    }
}
