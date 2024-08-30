using Week1;

namespace CalculatorTest;

public class CalculatorTest
{
    private readonly Calculator _calculator = new Calculator();
    
    [Theory]
    [InlineData(2,5,7)]
    [InlineData(-2,-3,-5)]
    [InlineData(0,0,0)]
    [InlineData(3.7,2.9,6.6)]
    public void Addition(float num1, float num2, float expected)
    {
        Assert.Equal(expected, _calculator.Sum(num1,num2), 2);
    }

    [Theory]
    [InlineData(5,2,3)]
    [InlineData(-3,-2,-1)]
    [InlineData(0,0,0)]
    [InlineData(3.7,2.9,0.8)]
    public void Subtraction(float num1, float num2, float expected)
    {
        Assert.Equal(expected, _calculator.Sub(num1, num2), 2);
    }

    [Theory]
    [InlineData(5,2,10)]
    [InlineData(-3,2,-6)]
    [InlineData(0,30,0)]
    [InlineData(1,1,1)]
    [InlineData(3.7,2.9,10.73)]
    public void Multiplication(float num1, float num2, float expected)
    {
        Assert.Equal(expected, _calculator.Mul(num1,num2), 2);
    }

    [Theory]
    [InlineData(10,5,2)]
    [InlineData(-3,-2,1.5)]
    [InlineData(1,1,1)]
    [InlineData(3.7,2.9,1.28)]
    public void Divition(float num1, float num2, float expected)
    {
        Assert.Equal(expected, _calculator.Div(num1, num2), 2);
    }

    [Fact]
    public void DivideByZero()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Div(3,0));
    }
}