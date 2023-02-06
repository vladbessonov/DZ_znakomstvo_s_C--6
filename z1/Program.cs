//  Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Создаем массив заданного размера

string message = $"Введите число:   ";
int InputInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreatArray(string message)
{
    int size = InputInt(message);
    int[] array = new int[size];
    return array;
}
// Функция заполнения массива
int[] FillArray(int[] array, string message)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputInt(message);
    }
    return array;
}
// функция печати массива:
void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}; "); // item - элемент массива
    }
    System.Console.WriteLine();
}

// Определение количества положительных чисел:
int PozitivNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = CreatArray("Введите количество сравниваемых чисел");

FillArray(array, message);
Console.WriteLine($"Введённые числа:");
PrintArray(array);
int count = PozitivNum(array);
Console.WriteLine($"Количество положительных чисел составляет - {count}");





