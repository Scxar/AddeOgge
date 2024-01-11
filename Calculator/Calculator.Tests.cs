using Xunit;
public class CalculatorTests
{
    [Fact]
    public void TestAddition()
    {
        Calculator1 calc = new();
        int a = 5;
        int b = 2;
        int expectedResult = 7;

        int result = calc.Add(a, b);

        Assert.Equal(expectedResult, result);

    }
}