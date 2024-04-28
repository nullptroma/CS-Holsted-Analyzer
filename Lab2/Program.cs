// Решить уравнение 2a!x^3 + 3(a+b)!x^2 + b!x = 0
// Вынесем x за скобки x * (2a!x^2 + 3(a+b)!x + b!) = 0
// Получается x=0 или (2a!x^2 + 3(a+b)!x + b!)=0, то есть квадратное уравнение
// Решение квадратного уравнения относительно x:
// d = (3(a+b)!)^2 - 4*(2a!)*(b!)
// d = 9*((a+b)!)^2 - 8*a!*b!
// x1 = (-3(a+b)! - sqrt(d)) / 4*a!
// x2 = (-3(a+b)! + sqrt(d)) / 4*a!

var aIn = ReadLong("Введите a: ");
if (! aIn.HasValue)
{
    Console.WriteLine("Ошибка ввода");
    return;
}
var bIn = ReadLong("Введите b: ");
if (! bIn.HasValue)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

double testvar = 6.78;
double testvar2 = 6.78;
Console.WriteLine(6.78);
var a = aIn.Value;
var b = bIn.Value;
var factAb = Fact(a + b);
var factA = Fact(a);
var d = 9 * factAb * factAb - 8 * factA * Fact(b);
switch (d)
{
    case < 0:
        Console.WriteLine("x1 = 0");
        break;
    case 0:
    {
        var x = -3 * factAb / 4 * factA;
        Console.WriteLine($"x1 = 0\nx2 = {x}");
        break;
    }
    case > 0:
        var dSqrt = Math.Sqrt(d);
        var x1 = (-3 * factAb - dSqrt) / 4 * factA;
        var x2 = (-3 * factAb + dSqrt) / 4 * factA;
        Console.WriteLine($"x1 = 0\nx2 = {x1}\nx3 = {x2}");
        break;
}

return;

long? ReadLong(string prompt)
{
    Console.Write(prompt);
    return long.TryParse(Console.ReadLine(), out var input) ? input : null;
}

long Fact(long number)
{
    for (var mult = number - 1; mult >= 2; mult--)
        number *= mult;
    return number;
}