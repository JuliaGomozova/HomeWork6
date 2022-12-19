/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
*/

//запросить натуральное число
int GetNaturalNumber (string numStr)
{
    bool isNum = false;
    int num = 0;
    
 
    while (!isNum)
    {   
        if (int.TryParse(numStr, out num) && num > 0)
            isNum = true;
        else 
        {
            Console.WriteLine("Некорректный ввод числа. Введите число > 0:");
            numStr = Console.ReadLine() ?? "";
        }
    }
    return num;
}

//запросить число
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
            Console.WriteLine("Некорректный ввод числа. Введите число:");
            numStr = Console.ReadLine() ?? "";
        }
    }
    return num;
}

//Ввод массива чисел с клавиатуры
double[] InitUserArray(int length)
{
    double[] array = new double[length];
    double number = 0;

    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i + 1} число:");
        number = GetNumber(Console.ReadLine() ?? "");
        array[i] = number;
    }

    return array;
}

//распечатать массив на консоль 
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

//подсчет отрицательных чисел в массиве
int CountPositiveInArray(double[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
            count ++;
    }
    return count;
}

Console.WriteLine("Сколько чисел Вы хотите ввести?");
int countNum =  GetNaturalNumber(Console.ReadLine() ?? "");
Console.WriteLine("");

double[] arrayNum = InitUserArray(countNum);
Console.WriteLine("");
PrintArray(arrayNum);

Console.WriteLine($"среди введенных чисел {CountPositiveInArray(arrayNum)} положительных");
