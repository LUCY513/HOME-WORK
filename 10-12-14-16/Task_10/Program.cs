﻿// 10. Показать вторую цифру трёхзначного числа                //   555 = 5*100 + 5*10 + 5*1
//   555 / 10 = 55 (5)
//  473 / 100 = 4(7)

int Randomiser()                                             // Создали функцию(метод) случайного числа
{
    int numFirst = new Random().Next(100, 1000);             // Задали переменную в которой будет генерироваться случайное число 
    return numFirst;                                         // Возврощаем полученный результат 
}

int Calculate(int numSecond)                                 // Создаем метод(функцию) нахождения второй цифры трехзнач. числа
{
    int number = (numSecond / 10) % 10;                      // Вычесляем наше число (546/10 = 54)%10 = 4)
    return number;                                           // Возврощаем полученный результат 
}

int resultFirst = Randomiser();                              // создаем переменную и вызываем нашу функцию случайного числа
int resultSecond = Calculate(resultFirst);                   // Создаем переменную и вызываем наш метод Нахождения второй цифры
                                                             // и задаем ей входное значение в виде числа которое мы получили из 
                                                             // метода случайного числа 
                      
Console.WriteLine($"Вторая цифра числа {resultFirst}: {resultSecond}");   // Выводим на консоль получившийся результат
