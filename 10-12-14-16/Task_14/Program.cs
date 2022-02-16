// 14. Найти третью цифру числа или сообщить, что её нет

/*245 = 2*100 + 4*10 + 5
245 / 10 = 24 (5)*/

int GetLastDigit(int num)                                              
{
    return num % 10;                                                   // деление с отсатком на 10 для получения последней цифры 
}

int Get(int min, int max)                                                
{
    int result = 0;                                                      
    bool isError = true;                                                 
    while(isError)                                                       
    {
        Console.Write($"Введите целое число от {min} до {max}: ");      
        string input = Console.ReadLine();                                
        result = int.Parse(input);
        //if(int.TryParse(input, out result));                            // преобразовывает буквы в цифры 
        isError = result < min || result > max;                         
    }
    return result;                                                      
}

int num = Get(100, 999);                                                
int lastDigit = GetLastDigit(num);                                        
Console.WriteLine(lastDigit);
