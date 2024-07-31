using MySuperbLib;

internal class Program
{
    private static void Main(string[] args)
    {
        var divide = Calculator.Divide(4, 8);
        var sum = Calculator.Sum(4, 8);
        var subtract = Calculator.Subtract(4, 8);
        var multiplicate = Calculator.Multiplicate(4, 8);

        Console.WriteLine($"{divide}, {sum}, {subtract}, {multiplicate}");
    }
}