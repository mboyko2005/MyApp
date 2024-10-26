using Xunit;
using MyApp;

namespace MyApp.Tests
{
	public class CalculatorTests
	{
		// ���� �� �������� ��������
		[Fact]
		public void Add_ReturnsCorrectSum()
		{
			// Arrange
			var calculator = new Calculator();
			int a = 5;
			int b = 5;

			// Act
			int result = calculator.Add(a, b);

			// Assert
			Assert.Equal(10, result);
		}

		// ���� �� �������� ������� ���������
		[Fact]
		public void ContainsWord_ReturnsTrue_WhenWordIsPresent()
		{
			// Arrange
			var calculator = new Calculator();
			string phrase = "Hello, world!";
			string word = "world";

			// Act
			bool result = calculator.ContainsWord(phrase, word);

			// Assert
			Assert.True(result);
		}

		// ���� �� �������� ������� � ��������� ���������� ��� ������� �� ����
		[Fact]
		public void Divide_ThrowsException_WhenDividingByZero()
		{
			// Arrange
			var calculator = new Calculator();
			int numerator = 10;
			int denominator = 0;

			// Act & Assert
			Assert.Throws<DivideByZeroException>(() => calculator.Divide(numerator, denominator));
		}
	}
}
