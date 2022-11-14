// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


void Main()
{
   Console.WriteLine("Введите число N");
    int N = int.Parse(Console.ReadLine()!);
   Console.WriteLine("Введите число M ");
    int M = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Сумма натуральных чисел между N и M =");
    Console.WriteLine(NumbersSumm(N, M));
}

int NumbersSumm(int n, int m)
{
    if (n>m) return 0;
    else return n + NumbersSumm(n+1, m); 

}


Main();
