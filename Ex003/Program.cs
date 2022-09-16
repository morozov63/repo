// See https://aka.ms/new-console-template for more information

============================================Задача1
Console.Clear();
Console.Write("Введите число А:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В:  ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Max = " + num1);   
}
else
{
     Console.WriteLine("Max = " + num2);    
}
=============================================Задача2
Console.Write("Введите число А:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В:  ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C:  ");
int num3 = Convert.ToInt32(Console.ReadLine());
int Max = num1;
   if (num2 > Max)
{
     Max = num2;
}
   if (num3 > Max)
{
   Max = num3;
}
Console.WriteLine("Max = " + Max);

==================================================Задача3  

Console.Write("Введите число :  ");
int num = Convert.ToInt32(Console.ReadLine());
    if (num%2 == 0)
{
    Console.WriteLine("Да, четное");
}
    else
{
    Console.WriteLine("Нет, нечетное");  
}
====================================================Задача4

Console.Write("Введите число :  ");
int num = Convert.ToInt32(Console.ReadLine());
int N = 1;
while (N <= num)
{
  N = N + 1;

    if (N%2==0)
{
    Console.WriteLine(N); 
}
}

