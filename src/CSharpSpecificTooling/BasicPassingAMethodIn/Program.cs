Console.WriteLine("Basic Passing a Method In");

var random = new Random();
var firstNumber = random.NextDouble();
var secodnNumber = random.NextDouble();
var decimalPlace = 3;


double firstResult = 0;
double secondResult = 0;

Round(firstNumber, secodnNumber,
    decimalPlace, 
    ref firstResult, 
    ref secondResult);

Console.WriteLine($"First result: {firstResult}");
Console.WriteLine($"Second result: {secondResult}");


static void Round(double firstNumb,
    double secondNum,
    int decimalPlace,
    ref double firstResult,
    ref double secondResult)
{
    firstResult = BaseRound(firstNumb, decimalPlace);
    secondResult = BaseRound(secondNum, decimalPlace);
}


static double BaseRound(double numberNeedsRounding, int decimalPlace)
{
    return Math.Round(numberNeedsRounding, decimalPlace);
}
