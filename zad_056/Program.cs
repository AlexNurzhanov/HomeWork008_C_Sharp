// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите через Enter количество строк и количество столбцов");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
Console.WriteLine("\nМассив");
//int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] matrix = new int[m, n];
Getmatrix(matrix);
Print(matrix);
void Getmatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(10);
    }
  }
}

void Print (int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
  }
}
int min = 0;
int sumLine = SumElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int temp = SumElements(matrix, i);
  if (sumLine > temp)
  {
    sumLine = temp;
    min = i;
  }
}

Console.WriteLine($"\n{min+1} - строкa с наименьшей суммой элементов ");// +1 для вывода номера строки(а не индекса строки)

int SumElements(int[,] matrix, int i)
{
  int sumLine = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumLine += matrix[i,j];
  }
  return sumLine;
}