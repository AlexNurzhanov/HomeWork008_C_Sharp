// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите через Enter два числа, отвечающие за размер двумерного массива");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

void GetArray( int[,] matrix)
{    
    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            matrix[i,j] = new Random().Next(100);
        }            
}

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
                Console.Write(matrix[i,j] + "  ");
            Console.WriteLine();
        }
}

void Sort( int[,] matrix)
{   
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; ++j)
                for (int k = 0; k < matrix.GetLength(1) - 1; ++k)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                        {
                            temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
        }
}

int[,] matrix = new int[m,n];

GetArray(matrix);

Console.WriteLine("\nДвумерный массив до преобразования");
Print(matrix);

Sort(matrix);

Console.WriteLine("\nДвумерный массив упорядоченный от максимального числа к минимальному, построчно");
Print(matrix);