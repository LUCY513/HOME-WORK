// 12. Удалить вторую цифру трёхзначного числа

// string s = "qwerty"
//             012345
// s[3] = r

string InPut()
{
    Console.Write("Введите число от 100 до 1000: ");
    string input = Console.ReadLine();
    return input; 
}

string array = InPut();
char[] number = new char[array.Length];

for (int i = 0; i < array.Length; i++)
{
    number[i] = array[i];
    //Console.Write($"{number[i]}");
}

Console.WriteLine($"{number[0]}{number[2]}");
