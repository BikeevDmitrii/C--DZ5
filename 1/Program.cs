//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void Random(int[] N)
{
    for (int i = 0; i < N.Length; i++)
    {
        N[i] = new Random().Next(100, 999);
    }
}
int Print(int[] array)
{
    int a = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
            a++;
            System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
    return a;
}
int[] number = new int[10];
Random(number);
System.Console.WriteLine($"Количество четных чисел массива = {Print(number)}");
