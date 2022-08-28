using System.Drawing;

namespace MultiplicationAtSpeed;

public static class ToyMath
{
    public static double[] Multiplication_at_Speed(double[] firstArray, double[] secondArray)
    {
        if (firstArray.Length != secondArray.Length)
        {
            throw new ArgumentException("The sizes of the arrays aren't the same");
        }

        var size = firstArray.Length;
        var multiplyResult = new double[size];

        Parallel.For(0, size, index =>
        {
            multiplyResult[index] = firstArray[index] * secondArray[index];
        });

        return multiplyResult;
    }
}
