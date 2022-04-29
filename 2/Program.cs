//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void Random(int[] N)
{
    for (int i = 0; i < N.Length; i++)
    {
        N[i] = new Random().Next(-100, 100);
    }
}
int Print(int[] array)
{
    int a = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 != 0)
            a = a + array[i];
            System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
    return a;
}
int[] number = new int[5];
Random(number);
System.Console.WriteLine($"Сумма нечетных элементов массива = {Print(number)}");
