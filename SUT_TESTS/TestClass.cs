using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SUT_2;



namespace SUT_TESTS
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void CheckAge_WhenValid_ResturnsTrue()
        {
            //arrange
            SUT myClass = new SUT ();
            // act
            bool actualResult = myClass.CheckAge(19);
            // assert
            Assert.That(actualResult, Is.True);
           
        }
        [Test]
        public void CheckAge_WhenNotValid_Too_Young_ExpectedFalse()
        {
            SUT myClass = new SUT();

            bool actualResult = myClass.CheckAge(14);
            // assert
            Assert.That(actualResult, Is.False);

        }

        [Test]
        public void CheckAge_WhenNotValid_Too_Old()
        {
            SUT myClass = new SUT();

            bool actualResult = myClass.CheckAge(24);
            // assert
            Assert.That(actualResult, Is.False);

        }

        [TestCase(17, ExpectedResult = false)]
        [TestCase(18, ExpectedResult = true)]
        [TestCase(19, ExpectedResult = true)]
        [TestCase(20, ExpectedResult = true)]
        [TestCase(21, ExpectedResult = true)]
        [TestCase(22, ExpectedResult = false)]


        public bool BoundryTests(int a)
        {
            SUT myClass = new SUT();
            bool actualResult = myClass.CheckAge(a);
            return actualResult;
        }

        [Test]
        public void CheckCost_When_ABC()
        {
            //arrange
            SUT myClass = new SUT();
            // act
            double actualResult = myClass.GetCost("ABC");
            // assert with a tolerance level
            Assert.That(actualResult, Is.EqualTo(10.10).Within(0.0001));

        }

        [TestCase("XYZ", ExpectedResult = 69.34)]
        [TestCase("FR45", ExpectedResult =34.0)]
        [TestCase("S34", ExpectedResult = 5)]
        [TestCase("G65", ExpectedResult = 5)]
        [TestCase("F34", ExpectedResult = 5)]
        [TestCase("t45", ExpectedResult = -999)]

        public double BoundryTests1(string a)
        {
            SUT myClass = new SUT();
            double actualResult = myClass.GetCost(a);
            return actualResult;
        }

        [Test]
        public void Checknumber_is_9()
        {
            //arrange
            SUT myClass = new SUT();
            // act
            int[] actualResult = new int[6];
            myClass.AllTheNines(actualResult);
            // assert
            Assert.That(actualResult, Is.All.EqualTo(9));

        }

        [Test]
        public void Checknumber_is_not_0()
        {
            //arrange
            SUT myClass = new SUT();
            // act
            int[] actualResult = new int[6];
            myClass.AllTheNines(actualResult);
            // assert
            Assert.That(actualResult, Is.All.Not.EqualTo(0));

        }

        [Test]
        public void Checkcounter_Greater_3()
        {
            //arrange
            SUT myClass = new SUT();
            // act
            int[] testarray = new int[] { 24, 55, 65, 21, 34, 90 };
            int actualresult = myClass.passCounter(testarray);
            // assert
            Assert.That(actualresult, Is.EqualTo(3));

        }

    }
}


