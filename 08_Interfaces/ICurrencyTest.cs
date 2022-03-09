using _08_Interfaces.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _08_Interfaces
{
    [TestClass]
    public class ICurrencyTest
    {
        [TestMethod]
        public void CurrencyValueTests()
        {
            ICurrency prenny = new Penny();
            ICurrency dime = new Dime();
            ICurrency dollar = new Dollar();

            Assert.AreEqual(.01m, prenny.Value);
            Assert.AreEqual(.1m, dime.Value);
            Assert.AreEqual(1m, dollar.Value);


        }

        [DataTestMethod]
        [DataRow (100.2)]
        [DataRow(300.00)]
        [DataRow(2.33)]
        public void ElectronicPayment_ShoudldReturnCorrectValue(double value)
        {
            decimal convertedValue = Convert.ToDecimal(value);
            var ePay = new ElectronicPayment(convertedValue);

            Assert.AreEqual(convertedValue, ePay.Value);
        }

    }
}
