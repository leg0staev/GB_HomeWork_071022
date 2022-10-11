Console.WriteLine("==============> Задача 19 <===============");
/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (можно решить через строку, а можно математически)
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Введите пятизначное число и я расскажу Вам полином это или нет: ");
String polinom = Console.ReadLine()!;
if (polinom.Length == 5){
    if (polinom[0] == polinom[4] && polinom[1] == polinom[3]){
    Console.WriteLine($"Да! число {polinom} полином!");
    }
    else{
     Console.WriteLine($"Нет :( число {polinom} не полином!");
    }
}
else{
    Console.WriteLine($"Число {polinom} не пятизначное");
}


Console.WriteLine("==============> Задача 21 <===============");
/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("Введите ниже координаты двух точек в трехмерном пространстве, и я рассчитаю расстояние между ними: ");
Console.WriteLine("Введите координату X первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"расстояние между точками => {distance:f2}");

Console.WriteLine("==============> Задача 23 <===============");
/* 
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.WriteLine("Введите любое число и я выведу строку значений кубов от 1 до Вашего числа: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i < number){
    double cube = Math.Pow(i, 3);
    i ++;
    Console.Write($"{cube}, ");
}
Console.WriteLine(Math.Pow(number, 3));