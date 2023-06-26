// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int [] NewArray (int size_array)
{
    int[] array = new int[size_array];
    for(int i = 0; i < size_array; i++)
    {
        array[i] = new Random().Next(0, 500);
    }
    return array;
}

void PrintArr (int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Input size");
int size = Convert.ToInt32(Console.ReadLine());
int[] remember = NewArray(size);
PrintArr(remember);


