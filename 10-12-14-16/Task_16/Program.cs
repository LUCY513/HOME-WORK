// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int InPut()
{
    Console.Write("Введите день недели: ");
    string input = Console.ReadLine();
    int num = int.Parse(input);
    return num;
}

int numFirst = InPut();
string result = String.Empty;

if (numFirst < 1 || numFirst > 7) result = "Такого дня недли нет";
if (numFirst == 1) result = "Понедельник\nБудний день";
if (numFirst == 2) result = "Вторник\nБудний день";
if (numFirst == 3) result = "Среда\nБудний день";
if (numFirst == 4) result = "Четверг\nБудний день";
if (numFirst == 5) result = "Пятница\nБудний день";
if (numFirst == 6) result = "Суббота\nВыходной день";
if (numFirst == 7) result = "Воскресенье\nВыходной день";

Console.Write(result);
