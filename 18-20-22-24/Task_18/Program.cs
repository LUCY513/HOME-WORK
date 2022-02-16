// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
//  !(x || y) = !x && !y 
// 1. x || y = z 
// 2. !z
// 3. !x && !y = e
// 4. z = e 
// 5. true || false
bool[] x = new bool[] { false, false, true, true };
bool[] y = new bool[] { false, true, false, true };

for (int i = 0; i < 4; i++)
{
    if (!(x[i] || y[i]) == (!x[i] && !y[i]));
    {

        Console.Write($" *{!(x[i] || y[i])}");

        Console.Write($"| {!x[i] && !y[i]}");

        Console.WriteLine($" #{(!(x[i] || y[i]) == (!x[i] && !y[i]))}");
    }
}