using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynom
{
    public class Polynomial
	{
		public int polynomialLength { get; private set; }
		public double[] coefficients { get; private set; }

		public Polynomial(params double[] coefficients)
		{
			polynomialLength = coefficients.Length;
			this.coefficients = coefficients;
		}

		/// <summary>
		/// Calculate polynomial with variable X.
		/// </summary>
		/// <param name="x">Variable to calculate polynomial</param>
		/// <returns></returns>
		public double Calculate(int x)
		{
			double result = 0;
			for (int i = 0; i < polynomialLength; i++)
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
			if (polynomialLength > 1)
			{
				for (int i = 1; i < polynomialLength; i++)
				{
					stringResult += " + " + coefficients[i].ToString() + "x^" + i.ToString();
				}
			}
			return stringResult;
		}

		public static Polynomial operator +(Polynomial ob1, Polynomial ob2)
		{
			int minLength;
			double[] coefficients;
			if (ob1.polynomialLength > ob2.polynomialLength)
			{
				minLength = ob2.polynomialLength;
				coefficients = ob1.coefficients;
			}
			else
			{
				minLength = ob1.polynomialLength;
				coefficients = ob2.coefficients;
			}
			for (int i = 0; i < minLength; i++)
			{
				coefficients[i] = ob1.coefficients[i] + ob2.coefficients[i];
			}
			return new Polynomial(coefficients);
		}

		public static Polynomial operator -(Polynomial ob1, Polynomial ob2)
		{
			int minLength;
			double[] coefficients;
			if (ob1.polynomialLength > ob2.polynomialLength)
			{
				minLength = ob2.polynomialLength;
				coefficients = ob1.coefficients;
			}
			else
			{
				minLength = ob1.polynomialLength;
				coefficients = ob2.coefficients;
			}
			for (int i = 0; i < minLength; i++)
			{
				coefficients[i] = ob1.coefficients[i] - ob2.coefficients[i];
			}
			for (int i = minLength; i < coefficients.Length; i++)
			{
				coefficients[i] = -coefficients[i];
			}
			return new Polynomial(coefficients);
		}

		public static Polynomial operator *(Polynomial ob1, Polynomial ob2)
		{
			int minLength;
			double[] coefficients;
			if (ob1.polynomialLength > ob2.polynomialLength)
			{
				minLength = ob2.polynomialLength;
				coefficients = ob1.coefficients;
			}
			else
			{
				minLength = ob1.polynomialLength;
				coefficients = ob2.coefficients;
			}
			for (int i = 0; i < minLength; i++)
			{
				coefficients[i] = ob1.coefficients[i] * ob2.coefficients[i];
			}
			return new Polynomial(coefficients);
		}

		/// <summary>
		/// Returns the hash code for current object.
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			int hash = 1;
			string x;
			for (int i = 0; i < polynomialLength; i++)
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

		public static bool operator ==(Polynomial ob1, Polynomial ob2)
		{
			return ob1.Equals(ob2);
		}

		public static bool operator !=(Polynomial ob1, Polynomial ob2)
		{
			return ob1.Equals(ob2) == true ? false : true;
		}

		/// <summary>
		/// Determines whether the specified object is equal to the current object.
		/// </summary>
		/// <returns></returns>
		public override bool Equals(object obj)
		{
			return obj.GetHashCode() == GetHashCode();
		}
	}
}
