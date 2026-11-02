using LAB07;

Function[] functions = new Function[10]
{
    new LinearFunction(0, 10, 2, 3),
    new LinearFunction(0, 10, 1, -1),
    new LogarithmicFunction(1, 10),
    new LogarithmicFunction(1, 5),
    new PowerFunction(0, 5, 2),
    new PowerFunction(0, 5, 3),
    new TrigonometricFunction(0, 10),
    new TrigonometricFunction(0, 6),
    new LinearFunction(0, 10, 0.5, 1),
    new PowerFunction(0, 5, 4)
};

double xAverage = 2;
double sum = 0;
int count = 0;

foreach (Function func in functions)
{
    try
    {
        double znach = func.Fun(xAverage);
        Console.WriteLine($"{func.FunctionName} [{func.LowerBound}; {func.UpperBound}]: f({xAverage})={znach:F2}");
        sum += znach;
        count++;
    }
    catch (ArgumentOutOfRangeException ex)
    { 
        Console.WriteLine(ex.Message );
    }
}
if(count > 0)
{
    double average = sum / count;
    Console.WriteLine($"\nСреднее значение в точке х={xAverage}: {average:F2}\n");
}

double xMax = 1;
double maxZnach = double.MinValue;
Function maxFunction = null;

foreach (Function func in functions)
{
    try
    {
        double znachenie = func.Fun(xMax);
        Console.WriteLine($"{func.FunctionName} [{func.LowerBound}; {func.UpperBound}]: f({xMax})={znachenie:F2}");

        if (znachenie > maxZnach)
        {
            maxZnach = znachenie;
            maxFunction = func;
        }
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message );
    }
}

if(maxFunction != null)
{
    Console.WriteLine($"\nФункция с макс. знач. в точке х={xMax}:");
    Console.WriteLine($"{maxFunction.FunctionName} [{maxFunction.LowerBound}; {maxFunction.UpperBound}] = {maxZnach:F2}\n");
}
Console.WriteLine(functions[0].ToString());
Console.WriteLine(functions[2].ToString());
Console.WriteLine(functions[4].ToString());
Console.WriteLine(functions[6].ToString());