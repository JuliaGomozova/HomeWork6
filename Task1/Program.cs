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

//запросить целое число
int GetNumber (string numStr)
{
    bool isNum = false;
    int num = 0;

    while (!isNum)
    {   
        if (int.TryParse(numStr, out num))
            isNum = true;
        else 
        {
            Console.WriteLine("Некорректный ввод числа. Введите число:");
            numStr = Console.ReadLine() ?? "";
        }
    }
    return num;
}

//Ввод массива целых чисел с клавиатуры
int[] InitUserArray(int length)
{
    int[] array = new int[length];
    int number = 0;

    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i + 1} число:");
        number = GetNumber(Console.ReadLine() ?? "");
        array[i] = number;
    }

    return array;
}

//распечатать массив на консоль 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

//подсчет отрицательных чисел в массиве
int CountNegativeInArray(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            count ++;
    }
    return count;
}

Console.WriteLine("Сколько чисел Вы хотите ввести?");
int countNum =  GetNaturalNumber(Console.ReadLine() ?? "");
Console.WriteLine("");

int[] arrayNum = InitUserArray(countNum);
Console.WriteLine("");
PrintArray(arrayNum);

Console.WriteLine($"среди введенных чисел {CountNegativeInArray(arrayNum)} отрицательных");
