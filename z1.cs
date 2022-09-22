/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

Print2dArr(SortRowsIn2dArr(Make2dArr(4,4)));



void Print2dArr(int[,] arr) {
    int x = arr.GetLength(0), y = arr.GetLength(1);
    string text = "Печать массива размером "+x+" на "+y;
    Console.WriteLine(text);
    for (int i = 0; i < x; i++)
    {
        Console.Write(i + ": |  ");
        for (int j = 0; j < y; j++)
        {
            string z = "";
            if (arr[i,j] / 10 < 1) z += " ";
            Console.Write(z + arr[i,j] + "  ");
        }
        Console.WriteLine("|");
    }
}

int [,] Make2dArr(int x, int y, int maxRnd = 100 )
{
    int [,] arr = new int [x,y];

    int n = 0;
    while( n < x){
         for ( int m = 0; m < y; m++ ){
            arr[n,m] = new Random().Next(1,maxRnd);
         }
        n++;
    }
    return arr;
}

int [,] SortRowsIn2dArr(int [,] arr) {
    int x = arr.GetLength(0), y = arr.GetLength(1);
    for (int i = 0; i < x; i++)
    {   
        int j = 0;
        while (j < y-1)
        {
            if(arr[i,j] < arr[i, j+1]) {
                int t = arr[i,j];
                arr[i,j] = arr[i,j+1];
                arr[i,j+1] = t;
                j = 0;
                continue;
            }
            j++;
        }
    }
    return arr;
}
