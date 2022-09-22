//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(Ak(m, n)); 

int Ak(int m, int n) {
    if(m == 0) return n+1;
    if(m != 0 && n == 0) return Ak(m-1, 1);
    return Ak(m-1, Ak(m, n-1));
}   
