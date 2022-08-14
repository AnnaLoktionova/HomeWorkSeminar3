/*Написать программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом*/
Console.WriteLine("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine());
string n1 = Convert.ToString(n);
if (n1[0] == n1[4] && n1[1] == n1[3]){
    Console.WriteLine("да");
}
else{
    Console.WriteLine("нет");
}