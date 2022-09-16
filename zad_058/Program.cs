// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите через Enter количество строк и количество столбцов");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

void GetArray( int[,] matrix)
{    
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(10);
        }            
}

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j] + "  ");
            }
            Console.WriteLine();
        }
}

int[,] Multi(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
        {
        for (int j = 0; j < matrix2.GetLength(1); j++)
            {
             for (int l = 0; l < matrix2.GetLength(0); l++)
                {
                result[i,j] += matrix1[i,l] * matrix2[l,j];
                }
            }
        }
    return result;
}

int[,] matrix1 = new int[m,n];
int[,] matrix2 = new int[n,m];

GetArray(matrix1);
GetArray(matrix2);

Console.WriteLine("\nПервая Матрица:");
Print(matrix1);
Console.WriteLine("\nВторая Матрица:");
Print(matrix2);

Console.WriteLine("\nРезультат произведения:");
Print(Multi(matrix1, matrix2));