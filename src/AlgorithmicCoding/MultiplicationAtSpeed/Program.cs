using MultiplicationAtSpeed;
using System.Diagnostics;

int size = 100000000;
var firstArray = new double[size];
var secondArray = new double[size];

Console.WriteLine($"Generation started at: {DateTime.Now}");

Parallel.ForEach(firstArray, item =>
{
    Random rnd = new Random();
    item = rnd.NextDouble();
});

Parallel.ForEach(secondArray, item =>
{
    Random rnd = new Random();
    item = rnd.NextDouble();
});

Console.WriteLine($"Done at: {DateTime.Now}");

var stopwatch = new Stopwatch();
stopwatch.Start();

var result = ToyMath.Multiplication_at_Speed(firstArray, secondArray);

stopwatch.Stop();
Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds}");
