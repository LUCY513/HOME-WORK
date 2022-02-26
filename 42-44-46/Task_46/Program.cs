// 46. Написать программу масштабирования фигуры
// Возьмем прямоугольник и его вершины 
// коэфицент масштабирования k = 2
using System.Linq;

string top = "(5,10) (5,5) (15,10) (15,5)"
                .Replace("(", "")
                .Replace(")", "");

Console.WriteLine(top);

var result = top.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Select(point => (point.x * 10, point.y * 10))
                .ToArray();

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}