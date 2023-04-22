// Задача 19: Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндроном.
// Пример: 
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число ");
int num = Convert.ToInt32(Console.ReadLine());
int a = (num % 100000)/10000;
int b = (num % 10000)/1000;
int c = (num % 1000)/100;
int d = (num % 100)/10;
int e = num % 10;
if ((a==e)&&(b==d))
{
    Console.WriteLine ("ДА");
  }
else
{
    Console.WriteLine ("НЕТ");
}

 
// Задача 21: Напишите программу, 
// которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве
// Пример:
// А(3,6,8);В(2,1,-7), -> 15.84
// А(7,-5,0);В(1,-1,9), -> 11.53

Console.WriteLine("Введите число A(x1) ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число A(y1) ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число A(z1) ");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B(x2) ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B(y2)");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B(z2) ");
int Z2 = Convert.ToInt32(Console.ReadLine());

double d=Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2));
d=Math.Round(d,2);
Console.WriteLine(d);


 
// Задача 23: Напишите программу, которая принимает на вход число (N) 
// и выдает таблицу кубов чисел от 1 до N.
// 3->1,8,27
// 5->1,8,27,64,125


Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i=1; i<=num; i++)
{
Console.WriteLine(Math.Pow(i,3));
}
