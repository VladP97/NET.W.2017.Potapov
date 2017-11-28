using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Test6.Solution;

namespace Task6.Tests
{
    public class FirstTest : IAlgorithm<int>
    {
        public int GetNumber(int x1, int x2)
        {
            return x1 + x2;
        }
    }

    public class SecondTest : IAlgorithm<int>
    {
        public int GetNumber(int x1, int x2)
        {
            return 6 * x1 - 8 * x2;
        }
    }

    public class ThirdTest : IAlgorithm<double>
    {
        public double GetNumber(double x1, double x2)
        {
            return x2 + x1 / x2;
        }
    }

    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            //First variant of test case exactly was incorrect?
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            int[] actual = Sequence<int>.GetSequnce(10, new FirstTest());

            for (int i = 0; i < actual.Length; i++)
            {
                Console.WriteLine(actual[i]);
            }

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, -10, 92, -796, 6920, -60136, 522608, -4541680, 39469088 };

            int[] actual = Sequence<int>.GetSequnce(10, new SecondTest());

            for (int i = 0; i < actual.Length; i++)
            {
                Console.WriteLine(actual[i]);
            }

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            double[] actual = Sequence<double>.GetSequnce(10, new ThirdTest());

            for (int i = 0; i < expected.Length; i++)
            {
                if (Math.Round(actual[i], 10) != Math.Round(expected[i], 10))
                {
                    Assert.Fail();
                }
            }
        }
    }
}
