// Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

int[] FillingArray(int n)
{
    int[] arr1 = new int[n];
    for (int i1 = 0; i1 < n; i1++) arr1[i1] = new Random().Next(1, 100);
    return arr1;
}

void PrintingArray(int[] arr2)
{
    for (int i2 = 0; i2 < arr2.Length; i2++) Console.Write(arr2[i2] + " ");
}

void CheckingEvenNumbersInArray(int[] arr3)
{
    int count = 0;
    for (int i3 = 0; i3 < arr3.Length; i3++)
    {
        if (arr3[i3] % 2 == 0) count++;
    }
    Console.Write($"=> {count}");
}

int[] arr = FillingArray(10);
PrintingArray(arr);
CheckingEvenNumbersInArray(arr);