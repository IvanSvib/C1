﻿////Домашнее задание. Тема 9. Урок 1. Поразрядные
////операции и операции присваивания.
//Console.WriteLine( "Логические операции.");
//int xy = 8 & 3;
//int xy1 = 22 & 4;
//int xy2 = 65 | 29;
//int xy3 = 44 |12;
//int xy4= 249 ^ 8;
//Console.WriteLine($"{xy}" +
//    $"\n{xy1}" +
//    $"\n{xy2}" +
//    $"\n{xy3}" +
//    $"\n{xy4}");


//Домашнее задание. Тема 9. Урок 2. Поразрядные
//операции и операции присваивания.
//1
long x1 = 256;
x1 = ~x1;
long x2 = 264895468854;
x2 = ~x2;
Console.WriteLine($"{x1}" +
    $"\n{x2}");

//2
int y = 2;
long n1 = 256;
n1 = n1 >> y;
long n2 = n1<< (y * y);

long n3 = 32856;
n3 = n3 >> y;
long n4 = n3 << (y * y);
Console.WriteLine($"{n1}" +
    $"\n{n2}" +
    $"\n{n3}" +
    $"\n{n4}");

//3
int q = 289;
q = 2487;
int w = 144;
w = 2487;
int e = 36274;
e = 2487;

Console.WriteLine($"{q}" +
    $"\n{w}" +
    $"\n{e}");

