
//Тема 10. урок 1
Console.WriteLine("Введите радиус(R) окружности:");
double R = double.Parse(Console.ReadLine()!);
double L = 2 * Math.PI * R;
double S = Math.PI * R * R;
double S1 = Math.Round(S);
double L1 = Math.Round(L);
Console.Write($"Длина окружности = {L1:F2}" +
    $"\n Площадь окружности равна {S1:F2}" +
    $"\n");

//Тема 1. Урок 2

Console.WriteLine("Введите значение катета a треугольника:");
double a = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение гипотенузы треугольника:");
double c = double.Parse(Console.ReadLine()!);
double b = c * (Math.Cos(a));
Console.Write($"Значение катета b = {b:F2}.");

