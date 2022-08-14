/* Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.*/

Console.WriteLine("Введите координату X1:");
double X1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y1:");
double Y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z1:");
double Z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату X2:");
double X2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y2:");
double Y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z2:");
double Z2 = double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((X2 - X1),2) + Math.Pow((Y2 - Y2),2) + Math.Pow((Z2 - Z1),2));

Console.WriteLine($"result = {result:f2}");

/*Console.WriteLine("Введите координаты точка A");
double A = double.Parse(Console.ReadLine());
string AA = Convert.ToString(A);
Console.WriteLine("Введите координаты точка B");
double B = double.Parse(Console.ReadLine());
string BB = Convert.ToString(B);

double result = Math.Sqrt(Math.Pow())*/