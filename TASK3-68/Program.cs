// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*
ackermann(0, 0); // 1
ackermann(2, 1); // 5
ackermann(2, 3); // 9*/

void Main()
{
   Console.WriteLine("Введите число N");
    int N = int.Parse(Console.ReadLine()!);
   Console.WriteLine("Введите число M ");
    int M = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Akkerman number = ");
    Console.WriteLine(Akkerman(N, M));
}

int Akkerman(int m, int n)
{
    if(m<=0) return n+1;
    else
    {
        if(m>0&&n<=0) return Akkerman(m-1, 1);
        else if(m>0&&n>0) return Akkerman(m-1, Akkerman(m, n-1));
        return 0;
    }
}

Main();