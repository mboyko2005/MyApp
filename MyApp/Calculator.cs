using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
	public class Calculator
	{
		public int Add(int a, int b)
		{
			return a + b;
		}

		public int Divide(int a, int b)
		{
			if (b == 0)
				throw new DivideByZeroException("Деление на ноль невозможно.");
			return a / b;
		}

		public bool ContainsWord(string phrase, string word)
		{
			return phrase.Contains(word);
		}
	}
}

