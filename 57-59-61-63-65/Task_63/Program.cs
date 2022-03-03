// 63. Сформировать трехмерный массив не повторяющимися двузначными числами 
// показать его построчно на экран выводя индексы соответствующего элемента

int[,,] array = new int[3, 4, 3]; // Представить тетрадку в клетку  [z, y, x] 
                                  // z - страницы,  y - строки,  x - столбцы  
int[,,] fillArr = FillArray(array);

PrintArray(fillArr);

int[,,] FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)                        // Проходимся по Z - страницам
    {
        for (int j = 0; j < arr.GetLength(1); j++)                    // Проходимся по каждой Y - строчке
        {
            for (int k = 0; k < arr.GetLength(2); k++)                // Проходимся по каждому X - столбику 
            {
                arr[i, j, k] = count++;
            }
        }
    }
    return arr;
}

void PrintArray(int[,,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)                 // Проходимся по Z - страницам 
    {
        Console.WriteLine                                        // Оглавление страницы
        ($"================ Array #{i + 1} ================== ");
        for (int j = 0; j < Array.GetLength(1); j++)             // Проходимся по каждой Y - строчке 
        {                       
            for (int k = 0; k < Array.GetLength(2); k++)         // Проходимся по каждому X - столбику 
            {
                Console.Write($"{Array[i, j, k]} ({i}, {j}, {k}) ○");
            }
            Console.WriteLine();                                 // Перелестнуть страницу 
        }
        Console.WriteLine();                        
    }
}