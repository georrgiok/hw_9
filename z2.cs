// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите размер двумерного квадратного массива");
Console.Write("По оси Х = ");
int x = Convert.ToInt32(Console.ReadLine());


Print2dArr(create2dArrSpiralFill(x));

/*
int [,] create2dArrSnakeFill(int x, int y) {
  int [,] arr = new int [x,y];
  int counter = 0, a1 = 0, a2 = 1;
  for (int i = 0; i < x; i++) {
    for (int j = 0; j < y; j++) {
        arr[i,(y-1)*a1+j*a2] = counter++;
    }
    if (a1 == 0) a1 = 1;
    else a1 = 0;

    if (a2 == -1) a2 = 1;
    else a2 = -1;
  }
  return arr;
}*/

int [,] create2dArrSpiralFill(int x) {
    int [,] arr = new int [x,x];
    int num = 1, i = 0, j = 0;
    while (num <= x * x){
        arr[i, j] = num;
        if (i <= j + 1 && i + j < x - 1) j++;
        else if (i < j && i + j >= x - 1) i++;
        else if (i >= j && i + j > x - 1) j--;
        else i--;
        num++;
    }


  return arr;
}

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
