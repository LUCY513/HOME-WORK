// 6. Выяснить является ли число чётным

int Randomiser()
{
    int num = new Random().Next(0, 99);                                      // Для экономии памяти стоит создавать один рандомайзер и к нему обрщаться в последствии
    return num;
}

int randomNum = Randomiser();
string result = String.Empty;

if (randomNum % 2 == 0) result = $"{randomNum} являеться четным:";
else
{
    result = $"{randomNum} неявляеться четным";
}


Console.WriteLine(result);
