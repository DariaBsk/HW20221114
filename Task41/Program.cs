// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3


int[] CreateArrayUserInt(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите элемент массива:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}


int PositiveNums(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}


Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());

if (m <= 0)
{
    Console.WriteLine($"Число {m} некорректно, нужно ввести целое положительное число.");
}
else
{
    int[] createArrayUserInt = CreateArrayUserInt(m);
    PrintArray(createArrayUserInt);
    int positiveNums = PositiveNums(createArrayUserInt);
    
    Console.WriteLine($"Количество положительных чисел в массиве: {positiveNums}");

}
