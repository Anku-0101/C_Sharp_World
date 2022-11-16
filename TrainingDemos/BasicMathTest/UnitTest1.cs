using NUnit.Framework;
using BasicMaths;
namespace BasicMathTest
{
    public class Tests
    {
        [Test]
        public void Test_AddMethod()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Add(4, 5);
            Assert.AreEqual(9, res);
            //Assert.Pass(res == 9);
        }

        [Test]
        public void Test_SubtractMethod()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Subtract(8, 9);
            Assert.AreEqual(-1, res);
        }

        [Test]
        public void Test_Divide()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Divide(8 , 2);
            Assert.AreEqual(4, res);
        }

        [Test]
        public void Test_Multiplication()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Multiply(4, 5);
            Assert.AreEqual(20, res);
        }
        
    }
}
