// 71. Написать программу вычисления функции Аккермана
//              n + 1                           m = 0;
//   A(m, n) =  A(m - 1, 1)                     m > 0, n = 0; 
//              A(m - 1, A(m,n - 1))            m > 0, n > 0;
// 
int n = 1;
int m = 1;

int result = rec(n, m);
Console.WriteLine(result);

int rec(int n, int m)
{
    if (n == 0)
        return (m + 1);
    if (m == 0)
        return rec(n - 1, 1);
    return rec(n - 1, rec(n, m - 1));
}