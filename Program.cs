namespace AndreasOscar;

public class Program
{
    public void messages()
    {
        [Fact]
        WriteLine("Hello, World!");

        WriteLine("Oscar skrev detta");

        WriteLine("Hello, Oscar!");

        int a = 5;
        int b = 2;

        int expected = 7;

        int result = a + b;

        Assert.Equals(expected, result);
    }
}
