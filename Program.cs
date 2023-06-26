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



// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Stepen (int num_A, int num_B)
{
    int sum = 1;
    for (int count = 1; count <= num_B; count++)
    {
        sum *= num_A;   
    } 
    return sum;
}
Console.WriteLine("input first number");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second number");
int second_num = Convert.ToInt32(Console.ReadLine());
int sum1 = Stepen(first_num, second_num);
Console.WriteLine(sum1);



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Sum(int num)
{
    
    int result = 0;
    while(num > 0)
    {    
        result = result + num % 10;
        num = num / 10;
    }
    return result;   
}
Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
int sum = Sum(number);
Console.WriteLine(sum);
