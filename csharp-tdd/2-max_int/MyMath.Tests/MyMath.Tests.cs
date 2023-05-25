using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
        int[,] testmatrix;
        int[] posFive = { 1, 2, 3, 4, 5 }, negFive = { -1, -2, -3, -4, -5 },
        centerPos = { 1, 2, 5, 3, 4 }, centerNeg = { -1, -2, 50, -3, -4 };
        List<int> testList;
        [SetUp]
        public void Setup()
        {
            testmatrix = new int[2, 2];
            testmatrix[0, 0] = 2;
            testmatrix[0, 1] = 4;
            testmatrix[1, 0] = 6;
            testmatrix[1, 1] = 8;
            testList = new List<int>();
        }


        public void NormalFunction(int value)
        {
            //int[,] res = MyMath.Matrix.Divide(testmatrix, value);
            //Assert.AreEqual(2 / value, res[0, 0]);
            Assert.Pass();
        }


        public void NullReturn()
        {
            //Assert.IsNull(MyMath.Matrix.Divide(null, 2));
            Assert.Pass();
        }


        public void DivideByZero()
        {
            //Assert.IsNull(MyMath.Matrix.Divide(testmatrix, 0));
            Assert.Pass();

        }

        [Test]
        public void MaxOfNone()
        {
            Assert.AreEqual(0, MyMath.Operations.Max(new List<int>()));
        }

        [Test]
        public void MaxOfFive()
        {
            testList.Clear();
            testList.AddRange(posFive);
            Assert.AreEqual(5, MyMath.Operations.Max(testList));
            testList.Clear();
        }

        [Test]
        public void MaxOfNegFive()
        {
            testList.Clear();
            testList.AddRange(negFive);
            Assert.AreEqual(-1, MyMath.Operations.Max(testList));
            testList.Clear();
        }

        [Test]
        public void CenterTest()
        {
            testList.Clear();
            testList.AddRange(centerPos);
            Assert.AreEqual(5, MyMath.Operations.Max(testList));
            testList.Clear();
            testList.AddRange(centerNeg);
            Assert.AreEqual(50, MyMath.Operations.Max(testList));
            testList.Clear();
            testList.Add(5);
            Assert.AreEqual(5, MyMath.Operations.Max(testList));
            testList.Clear();
        }

        [Test]
        public void NullList()
        {
            Assert.AreEqual(0, MyMath.Operations.Max(null));
        }

        [Test]
        public void MaxOfOne()
        {
            testList.Clear();
            testList.Add(1);
            Assert.AreEqual(1, MyMath.Operations.Max(testList));
            testList.Clear();
        }

    }
}