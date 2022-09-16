// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите через Enter количество строк и количество столбцов двумерного массива");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Спиральный двумерный Массив:");
int[,] number = new int[m, n];
int size = 1;
int arr1 = 0, arr2 = n - 1;
while (size <= n * n)
{
    for (int i = arr1; i <= arr2; i++)
    {
        number[arr1, i] = size++;
    }

    for (int j = arr1 + 1; j <= arr2; j++)
    {
        number[j, arr2] = size++;
    }

    for (int i = arr2 - 1; i >= arr1; i--)
    {
        number[arr2, i] = size++;
    }

    for (int j = arr2 - 1; j >= arr1 + 1; j--)
                number[j, arr1] = size++;
                arr1++;
                arr2--;
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("{0, 4}", number[i, j]);
    }
    Console.WriteLine();
}