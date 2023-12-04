//Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
// массив [10 21 14 93 23] => 2

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

void CheckingArray(int[] arr3)
{
    int count = 0;
    for (int i3 = 0; i3 < arr3.Length; i3++)
    {
        if (arr3[i3] > 19 && arr3[i3] < 91) count++;
    }
    Console.Write($"=> {count}");
}


int[] arr = FillingArray(10);
PrintingArray(arr);
CheckingArray(arr);

