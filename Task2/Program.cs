/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

//запросить  число
double GetNumber (string numStr)
{
    bool isNum = false;
    double num = 0;

    while (!isNum)
    {   
        if (double.TryParse(numStr, out num))
            isNum = true;
        else 
        {
            Console.WriteLine("Некорректный ввод числа. Введите целое число:");
            numStr = Console.ReadLine() ?? "";
        }
    }
    return num;
}

//найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2
(double, double) FindDotLineCrossing(double k1, double b1, double k2, double b2)
{
    double x = ((b2 - b1)/(k1 - k2));
    double y = k1*x+b1;
    return (x, y);
}


Console.WriteLine("Найдём точку пересечения прямых, заданных уравнениями: y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Для этого введите k1 = ");
double k1 = GetNumber(Console.ReadLine() ??"");

Console.Write("Введите b1 = ");
double b1 = GetNumber(Console.ReadLine() ??"");

Console.Write("Введите k2 = ");
double k2 = GetNumber(Console.ReadLine() ??"");

Console.Write("Введите b2 = ");
double b2 = GetNumber(Console.ReadLine() ??"");

Console.WriteLine($"Точка пересечения прямых заданных уравнениями y = {k1}*x + {b1} и y = {k2}*x + {b2}");
Console.WriteLine($" координаты (x, y) = {FindDotLineCrossing(k1, b1, k2, b2)}");