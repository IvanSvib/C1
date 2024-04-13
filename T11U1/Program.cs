using System;

Console.WriteLine("Введите 10 чисел:");
double  x = double.Parse(Console.ReadLine());
double x1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double x3 = double.Parse(Console.ReadLine());
double x4 = double.Parse(Console.ReadLine());
double x5 = double.Parse(Console.ReadLine());
double x6 = double.Parse(Console.ReadLine());
double x7 = double.Parse(Console.ReadLine());
double x8 = double.Parse(Console.ReadLine());
double x9 = double.Parse(Console.ReadLine());
////Условие 1
//double summa = (x +
//x1 +
//x2 +
//x3 +
//x4 +
//x5 +
//x6 +
//x7 +
//x8 +
//x9);
//Console.WriteLine($"Сумма всех чисел = {summa}:");
////Условие 2
//double n =x > 10?x=1:0;
//double n1 = x1 > 10?x=1:0;
//double n2 = x2 > 10?x=1:0;
//double n3 = x3 > 10?x=1:0;
//double n4 = x4 > 10?x=1:0;
//double n5 = x5 > 10?x=1:0;
//double n6 = x6 > 10?x=1:0;
//double n7 = x7 > 10?x=1:0;
//double n8 = x8 > 10?x=1:0;
//double n9 = x9 > 10?x=1:0;
//double summa1 = (n + n1 +n2 +n3 +n4 + n5 +n6 +n7+n8 +n9);
//Console.WriteLine($"{summa1} чисел больших 10.");
////Условие 3
//double y = x < -10 ? y = 1 : 0;
//double y1 = x1 < -10 ?y1= 1 : 0;
//double y2 = x2 < -10 ?y2= 1 : 0;
//double y3 = x3 < -10 ?y3= 1 : 0;
//double y4 = x4 < -10 ?y4= 1 : 0;
//double y5 = x5 < -10 ?y5= 1 : 0;
//double y6 = x6 < -10 ?y6= 1 : 0;
//double y7 = x7 < -10 ?y7= 1 : 0;
//double y8 = x8 < -10 ?y8= 1 : 0;
//double y9 = x9 < -10 ? y9 = 1 : 0;
//double summa2 = (y + y1 + y2 + y3 + y4 + y5 + y6 + y7 + y8 + y9);
//Console.WriteLine($"{summa2} чисел меньших -10.");
////Условие 4
//Console.WriteLine($"среднее арифметическое всех чисел = {summa/10}.");
//Условие 5
double m = x >= x1 ? x : x1;
double m1 = m >= x2 ? m : x2;
double m2 = m1 >= x3 ? m1 : x3;
double m3 = m2 >= x4 ? m2 : x4;
double m4 = m3 >= x5 ? m3 : x5;
double m5 = m4 >= x6 ? m4 : x6;
double m6 = m5 >= x7 ? m5 : x7;
double m7 = m6 >= x8 ? m6 : x8;
double m8 = m7 >= x9 ? m7 : x9;
Console.WriteLine($"Максимальное значение всех чисел {m8}.");
double n = x < x1 ? x : x1;
double n1 = n <x2 ? n : x2;
double n2 = n1 < x3 ? n1 : x3;
double n3 = n2 < x4 ? n2 : x4;
double n4 = n3 < x5 ? n3 : x5;
double n5 = n4 < x6 ? n4 : x6;
double n6 = n5 < x7 ? n5 : x7;
double n7 = n6 < x8 ? n6 : x8;
double n8 = n7 < x9 ? n7 : x9;
Console.WriteLine($"Минимальное значение всех чисел {n8}.");



