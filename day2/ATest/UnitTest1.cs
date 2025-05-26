using Xunit;
using task1;
using System;
namespace ATest;
public class ATests
{
    [Fact]
    public void Equation_ReturnsExpectedResult()
    {
        // Проверка для a = 2, b = 4
        var a = new A(2, 4);
        // (3*4 - (2/2^2))/4 = (12 - (2/4))/4 = (12 - 0)/4 = 3
        Assert.Equal(3, a.Equation());
    }

    [Fact]
    public void Equation_DivideByZero_ThrowsException()
    {
        // a = 0 вызовет деление на ноль
        var a = new A(0, 4);
        Assert.Throws<DivideByZeroException>(() => a.Equation());
    }

    [Fact]
    public void Square_ReturnsExpectedResult()
    {
        // Проверка для a = 2, b = 3: 2^3 = 8
        var a = new A(2, 3);
        Assert.Equal(8.0, a.Square());
    }

    [Theory]
    [InlineData(3, 2, 9.0)] // 3^2 = 9
    [InlineData(5, 0, 1.0)] // 5^0 = 1
    [InlineData(2, -2, 0.25)] // 2^-2 = 0.25
    public void Square_WorksForVariousInputs(int aValue, int bValue, double expected)
    {
        var a = new A(aValue, bValue);
        Assert.Equal(expected, a.Square(), 5); // 5 знаков после запятой
    }
}