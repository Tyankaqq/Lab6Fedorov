//задача 28
Console.Write("введите y:");
double y = double.Parse(Console.ReadLine());
Console.Write("введите r:");
double r = double.Parse(Console.ReadLine());
double W = Math.Exp(y + r) + 7.2 * Math.Sin(r);
Console.WriteLine($"W ={W:F2}");
//задача 29
double N = y * y + Math.Sqrt(Math.Abs(y + 1));
Console.WriteLine($"N={N:F2}");
//задача 30
Console.Write("введите y:");
double y = double.Parse(Console.ReadLine());
Console.Write("введите r:");
double r = double.Parse(Console.ReadLine());
double W = Math.Exp(y + r) + 7.2 * Math.Sin(r);
Console.Write("введите p:");
double p = double.Parse(Console.ReadLine());
double n = (3*y*y+Math.Sqrt(y+1)) / (Math.Log(p+y)+Math.Exp(p));
Console.WriteLine($"N={N:F2}");

