//Тернарная структура выбора
//функция хэвисайда == y {0, x < 0 && 1, x > 0}
//Console.Write("Введите x");
//double x = double.Parse(Console.ReadLine());
//double y;
//if (x < 0) y = 0;
//else y = 1;
//Console.WriteLine("y="+y);
//y = (x < 0) ? 0 : 1;
//Console.WriteLine("y=" + y)


//Console.Write("Введите x:");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Введите y:");
//double  y = double.Parse(Console.ReadLine());
//Console.Write("Введите радиус окрудности R:");
//double R = double.Parse(Console.ReadLine());
//Console.WriteLine((x * x + y * y <= R * R) ? "Принадлежит" : "Не принадлежит");


//Console.Write("Введите x:");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Введите y:");
//double y = double.Parse(Console.ReadLine());
//Console.WriteLine($"{((x > 0) ? Math.Sin(x) * Math.Sin(x) : 1 - 2 * Math.Sin(x * x)):F2}");



//using System.ComponentModel.Design;

//Console.Write("Введите a:");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите b:");
//double b = double.Parse(Console.ReadLine());
//if (a > b) Console.WriteLine($"{a}>{b}"); 
//else if (a < b) Console.WriteLine($"{a}<{b}");
//else  Console.WriteLine($"{a} = {b}"); 

Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите y:");
double y = double.Parse(Console.ReadLine());
double max, min;
if (x >y)
{
    max = y; min = x;
}
{
    max = y; min = x;
}
Console.WriteLine($"max ={max} min = {min}");

