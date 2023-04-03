using net_calculator_tester;
using System.Net.NetworkInformation;

namespace test
{
    public class Tests
    {
        public Calculator calc;
        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        
        public void TestAdd()
        {
            var result = calc.AddFloat(2.1f,2.2f);
            Assert.AreEqual(4.3f,result,"la somma è sbagliata");
        }

        [Test]
        public void TestMultiply()
        {
            var result = calc.MultiplyFloat(2.1f, 2.2f);
            Assert.AreEqual(4.62f, result, "la moltiplicaione è sbagliata");
        }

        [Test]
        public void TestSubtract()
        {
            var result = calc.SubtractFloat(2.5f, 2.1f);
            Assert.Greater(5.4f, result, "la sottrazione è sbagliata");
        }

        [Test]
        public void TestDivide()
        {
            var result = calc.DivideFloat(4.0f, 2.0f);
            Assert.AreEqual(2.0f, result, "la divisione è sbagliata");
        }


    }
}