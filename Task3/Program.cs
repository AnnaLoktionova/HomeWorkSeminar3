// написать программу, которая принимает на вход число N и выдает таблицу кубов от 1 до N
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

for(int a = 1; a <= N; a++){
    Console.WriteLine(a * a * a);
}