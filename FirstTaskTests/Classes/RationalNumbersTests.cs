using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstTask.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.Classes.Tests
{
    [TestClass()]
    public class RationalNumbersTests
    {
        [TestMethod()]
        
        public void OperatorEqualPropertiesCorrectly()
        {
            RationalNumbers rationalNumbers1 = new RationalNumbers(2, 5);
            RationalNumbers rationalNumbers2 = new RationalNumbers(2, 5);
            bool equal = rationalNumbers1 == rationalNumbers2;
            Assert.IsTrue(equal);
        }
        [TestMethod()]
        public void OperatorNotEqualPropertiesCorrectly()
        {
            RationalNumbers rationalNumbers1 = new RationalNumbers(3, 5);
            RationalNumbers rationalNumbers2 = new RationalNumbers(2, 5);
            bool equal = rationalNumbers1 != rationalNumbers2;
            Assert.IsTrue(equal);
        }
        [TestMethod()]
        public void OperatorMorelPropertiesCorrectly()
        {
            RationalNumbers rationalNumbers1 = new RationalNumbers(10, 5);
            RationalNumbers rationalNumbers2 = new RationalNumbers(1, 5);
            bool equal = rationalNumbers1 > rationalNumbers2;
            Assert.IsTrue(equal);
        }
        [TestMethod()]
        public void OperatorLesslPropertiesCorrectly()
        {
            RationalNumbers rationalNumbers1 = new RationalNumbers(1, 5);
            RationalNumbers rationalNumbers2 = new RationalNumbers(10, 5);
            bool equal = rationalNumbers1 < rationalNumbers2;
            Assert.IsTrue(equal);
        }
        [TestMethod()]
        public void OperatorMoreEquallPropertiesCorrectly()
        {
            RationalNumbers rationalNumbers1 = new RationalNumbers(1, 5);
            RationalNumbers rationalNumbers2 = new RationalNumbers(1, 5);
            bool equal = rationalNumbers1 >= rationalNumbers2;
            Assert.IsTrue(equal);
        }
        [TestMethod()]
        public void OperatorLessEquallPropertiesCorrectly()
        {
            RationalNumbers rationalNumbers1 = new RationalNumbers(1, 5);
            RationalNumbers rationalNumbers2 = new RationalNumbers(1, 5);
            bool equal = rationalNumbers1 <= rationalNumbers2;
            Assert.IsTrue(equal);
        }
    }
}