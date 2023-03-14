// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n/10000;
int n2 = (n/1000) % 10;
int n4 = (n/10) % 10;
int n5 = n % 10;
if (n1 == n5 && n2 == n4)
    Console.WriteLine("Число является полиндромом");
else
    Console.WriteLine("Число не является полиндромом");


