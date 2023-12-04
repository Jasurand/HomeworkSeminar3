// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] FillingArray(int n)
{
    double[] arr1 = new double[n];
    for (int i1 = 0; i1 < n; i1++) arr1[i1] = new Random().Next(1, 100);
    return arr1;
}

void PrintingArray(double[] arr2)
{
    for (int i2 = 0; i2 < arr2.Length; i2++) Console.Write(arr2[i2] + " ");
    Console.WriteLine();
}

double SearchingMin(double[] arr3)
{
    double min = arr3[0];
    for (int i3 = 0; i3 < arr3.Length; i3++)
    {
        if (arr3[i3] < min) min = arr3[i3];
    }
    return min;
}

double SearchingMax(double[] arr4)
{
    double max = arr4[0];
    for (int i4 = 0; i4 < arr4.Length; i4++)
    {
        if (arr4[i4] > max) max = arr4[i4];
    }
    return max;
}

double[] arr = FillingArray(10);
PrintingArray(arr);
double Max = SearchingMax(arr);
double Min = SearchingMin(arr);
Console.WriteLine($"{Max} - {Min} = {Max - Min}");