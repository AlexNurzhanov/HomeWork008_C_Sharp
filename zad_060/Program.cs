// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int m = 2;
int n = 2;
int o = 2;

void GetArray( int[,,] matrix)
{
    int[] count = new int[10];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
                {
                    matrix[i, j, l] = new Random().Next(10);
                    while (count[matrix[i, j, l]] > 0)
                        matrix[i, j, l] = new Random().Next(10);
                    count[matrix[i, j, l]]++;
                }
        }
    }
}

void Print(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int l = 0; l < matrix.GetLength(2); l++)
                        Console.Write("{0} ( {1}, {2}, {3} )  ", matrix[j, l, i], j, l, i);
                    Console.WriteLine();
                }
        }
}

int[,,] output = new int[m,n,o];
GetArray(output);
Console.WriteLine("\nОтвет:");
Print(output);