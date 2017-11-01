using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynom
{
    public class Polynomial
	{
		private int degree;
		private double[] coefficients;

		public int Degree
		{
			get
			{
				return coefficients.Length - 1;
			}
		}

		public double this[int number]
		{
			get
			{
				if (number > degree - 1)
				{
					throw new ArgumentOutOfRangeException();
				}
				return coefficients[number];
			}
		}

		public Polynomial(params double[] coefficients)
		{
			degree = coefficients.Length;
			this.coefficients = new double[degree];
			Array.Copy(coefficients,this.coefficients, degree);
			Console.WriteLine(this.coefficients);
		}

		/// <summary>
		/// Calculate polynomial with variable X.
		/// </summary>
		/// <param name="x">Variable to calculate polynomial</param>
		/// <returns></returns>
		public double Calculate(int x)
		{
			double result = 0;
			for (int i = 0; i < degree; i++)
			{
				result += Math.Pow(x, i) * coefficients[i];
			}
			return result;
		}

		/// <summary>
		/// Returns a string that represents the current object.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string stringResult = coefficients[0].ToString();
			if (degree > 1)
			{
				for (int i = 1; i < degree; i++)
				{
					stringResult += " + " + coefficients[i].ToString() + "x^" + i.ToString();
				}
			}
			return stringResult;
		}

		public static Polynomial operator +(Polynomial firstPolynom, Polynomial secondPolynom)
		{
			int minLength;
			double[] coefficients;
			if (firstPolynom.degree > secondPolynom.degree)
			{
				minLength = secondPolynom.degree;
				coefficients = firstPolynom.coefficients;
			}
			else
			{
				minLength = firstPolynom.degree;
				coefficients = secondPolynom.coefficients;
			}
			for (int i = 0; i < minLength; i++)
			{
				coefficients[i] = firstPolynom.coefficients[i] + secondPolynom.coefficients[i];
			}
			return new Polynomial(coefficients);
		}

		/// <summary>
		/// Summarizes coefficients of two polynomials.
		/// </summary>
		/// <param name="ob1">First polynom to sum.</param>
		/// <param name="ob2">Second polynom to sum.</param>
		/// <returns></returns>
		public static Polynomial Add(Polynomial firstPolynom, Polynomial secondPolynom)
		{
			return firstPolynom + secondPolynom;
		}

		public static Polynomial operator -(Polynomial firstPolynom, Polynomial secondPolynom)
		{
			int minLength;
			double[] coefficients;
			if (firstPolynom.degree > secondPolynom.degree)
			{
				minLength = secondPolynom.degree;
				coefficients = firstPolynom.coefficients;
			}
			else
			{
				minLength = firstPolynom.degree;
				coefficients = secondPolynom.coefficients;
			}
			for (int i = 0; i < minLength; i++)
			{
				coefficients[i] = firstPolynom.coefficients[i] - secondPolynom.coefficients[i];
			}
			for (int i = minLength; i < coefficients.Length; i++)
			{
				coefficients[i] = -coefficients[i];
			}
			return new Polynomial(coefficients);
		}

		/// <summary>
		/// Subtracts coefficients of two polynomials.
		/// </summary>
		/// <param name="firstPolynom">First polynom to sub.</param>
		/// <param name="secondPolynom">Second polynom to sub.</param>
		/// <returns></returns>
		public static Polynomial Sub(Polynomial firstPolynom, Polynomial secondPolynom)
		{
			return firstPolynom - secondPolynom;
		}

		public static Polynomial operator *(Polynomial firstPolynom, Polynomial secondPolynom)
		{
			int minLength;
			double[] coefficients;
			if (firstPolynom.degree > secondPolynom.degree)
			{
				minLength = secondPolynom.degree;
				coefficients = firstPolynom.coefficients;
			}
			else
			{
				minLength = firstPolynom.degree;
				coefficients = secondPolynom.coefficients;
			}
			for (int i = 0; i < minLength; i++)
			{
				coefficients[i] = firstPolynom.coefficients[i] * secondPolynom.coefficients[i];
			}
			return new Polynomial(coefficients);
		}

		/// <summary>
		/// Multiply coefficients of two polynomials.
		/// </summary>
		/// <param name="firstPolynom">First polynom to multiply.</param>
		/// <param name="secondPolynom">Second polynom to multiply.</param>
		/// <returns></returns>
		public static Polynomial Multiply(Polynomial firstPolynom, Polynomial secondPolynom)
		{
			return firstPolynom * secondPolynom;
		}

		/// <summary>
		/// Returns the hash code for current object.
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			int hash = 1;
			string x;
			for (int i = 0; i < degree; i++)
			{
				x = (coefficients[i] % 1).ToString();
				if (x.Length > 1)
				{
					x = x.Remove(0, 2);
				}
				hash *= int.Parse(x) + (int)(coefficients[i]) * ((i + 1) * 42);
			}
			return hash;
		}

		public static bool operator ==(Polynomial firstPolynom, Polynomial secondPolynom)
		{
			return firstPolynom.Equals(secondPolynom);
		}

		public static bool operator !=(Polynomial firstPolynom, Polynomial secondPolynom)
		{
			return !firstPolynom.Equals(secondPolynom);
		}

		/// <summary>
		/// Determines whether the specified object is equal to the current object.
		/// </summary>
		/// <returns></returns>
		public override bool Equals(object polynom)
		{
			if (ReferenceEquals(this, polynom))
			{
				return true;
			}
			if (GetType() != polynom.GetType())
			{
				return false;
			}
			return polynom.GetHashCode() == GetHashCode();
		}
	}
}
