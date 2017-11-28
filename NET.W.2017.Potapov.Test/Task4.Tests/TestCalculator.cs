using System;
using System.Collections.Generic;
using NUnit.Framework;
using Task4.Solution;

namespace Task4.Tests
{
    public class Mean : ICalculate<double>
    {
        public double Calculate(List<double> values)
        {
            values.Sort();

            int n = values.Count;

            if (n % 2 == 1)
            {
                return values[(n - 1) / 2];
            }

            return (values[n / 2 - 1] + values[n / 2]) / 2;
        }

        private double[] ToArray(List<double> values)
        {
            double[] array = new double[values.Count];
            int i = 0;
            foreach (var item in values)
            {
                array[i] = item;
                i++;
            }
            return array;
        } 
    }

    public class Median : ICalculate<double>
    {
        public double Calculate(List<double> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }
            return Sum(values) / values.Count;
        }

        private double Sum(List<double> values)
        {
            double result = 0;
            foreach (var item in values)
            {
                result += item;
            }

            return result;
        }
    }

    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };
        Calculator<double> calculator = new Calculator<double>();

        [Test]
        public void Test_AverageByMean()
        {         
            calculator.Add(new Mean());

            double expected = 8.3636363;

            double actual = calculator[0].Calculate(values);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian()
        {
            calculator.Add(new Median());

            double expected = 8.3636363;

            double actual = calculator[1].Calculate(values);

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}