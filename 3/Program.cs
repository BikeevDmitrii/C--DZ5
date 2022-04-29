//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3, 7, 22, 2, 78] -> 76

double Max(double[] array)
{
    double a = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > a )
            a = array[i];
            System.Console.Write($"{array[i]} ");
    }
    return a;
}
double Min(double[] array)
{
    double b = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < b )
            b = array[i];
    }
   System.Console.WriteLine();
    return b;
}
double[] number = { 1.1, 2.1, 4.32, 8.4, 7.9, 2.5, 15.6};
System.Console.WriteLine($"max = {Max(number)}, min = {Min(number)}");
System.Console.WriteLine($"Разность между максимальными и минимальным = {Max(number) - Min(number)}");