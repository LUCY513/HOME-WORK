// Даны два числа. Показать большее и меньшее число

/*
int A = 6990, B = 911;

if (A > B)
{
    Console.WriteLine($"Большее число: {A}");
    Console.WriteLine($"Меньшее число: {B}");
}
else
{
    Console.WriteLine($"Большее число: {B}");
    Console.WriteLine($"Меньшее число: {A}");
}
*/

int RandomNumber()
{
    int a = new Random().Next(1, 100);
    return a;
}

int randomNum1 = RandomNumber();
Console.WriteLine($"Первое число: {randomNum1}");
int randomNum2 = RandomNumber();
Console.WriteLine($"Второе число: {randomNum2}");

if (randomNum1 > randomNum2)
{
    Console.WriteLine($"Большее число: {randomNum1}");
    Console.WriteLine($"Меньшее число: {randomNum2}");
}
else
{
    Console.WriteLine($"Большее число: {randomNum2}");
    Console.WriteLine($"Меньшее число: {randomNum1}");
}