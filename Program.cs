int divisible = 0;
int indivisible = 0;

for (double i = 13; i < 24; i++)
{
    double y = (2 * i * 4 / 11);

    if (Math.Round(y) % 11 == 0)
    {

        Console.WriteLine("For x equal to: " + i + " function value is: " + y.ToString("0.00"));
        Console.WriteLine("Rounded: " + Math.Round(y));
        Console.WriteLine("Is divisible by 11");
        Console.WriteLine("----------");
        divisible++;
    }
    else
    {
        Console.WriteLine("For x equal to: " + i + " function value is: " + y.ToString("0.00"));
        Console.WriteLine("Rounded: " + Math.Round(y));
        Console.WriteLine("Is not divisible by 11");
        Console.WriteLine("----------");
        indivisible++;
    }
}

Console.WriteLine("Numbers divisible by 11: " + divisible);
Console.WriteLine("Numbers not divisible by 11: " + indivisible);