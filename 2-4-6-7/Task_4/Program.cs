// 4. Найти максимальное из трех чисел

int RandomNumber()
{
    int number = new Random().Next(1, 110);
    return number;
}

int A = RandomNumber();
int B = RandomNumber();
int C = RandomNumber();
Console.WriteLine($"{A} {B} {C}");

int max = A;
if (B > max) max = B;
if (C > max) max = C;

/*                                                   // Нахлждение минимального значения 
int min = A;
if (B < min) min = B;
if (C < min) min = C;
*/

Console.WriteLine($"Наибольшее число: {max}");

//Console.WriteLine($"Наименьшее число: {min}");