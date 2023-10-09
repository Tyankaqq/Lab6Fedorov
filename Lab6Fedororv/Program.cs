//задание 13 высокий уровень
Console.Write("Введите n:");
double n = double.Parse(Console.ReadLine());
Console.WriteLine("Введите x:");
int x = int.Parse(Console.ReadLine());
double k, r, s, y;

switch (n) 
{
    case 1:
        {

            k = 1.33;
            r = 0.85;
            s = 3.5;
            if (Math.Cos(x) == Math.Cos(r * s)) y = (Math.Pow(x, 2) * Math.Exp(2 * k) * k + Math.Log(Math.Abs(r * x)));
            else if (Math.Cos(x) > Math.Cos(r * s)) y = Math.Pow(x, 2 / 3) + Math.Sqrt(Math.Abs(k + r * s * x));
            else y = (Math.Atan(k * x + r * s));
            Console.WriteLine($"y = {y}");
        }
        break;
    case 2:
        {

            k = 0.9;
            r = 3.3;
            s = 1.2;
            if (Math.Cos(x) == Math.Cos(r * s)) y = (Math.Pow(x, 2) * Math.Exp(2 * k) * k + Math.Log(Math.Abs(r * x)));
            else if (Math.Cos(x) > Math.Cos(r * s)) y = Math.Pow(x, 2 / 3) + Math.Sqrt(Math.Abs(k + r * s * x));
            else y = (Math.Atan(k * x + r * s));
            Console.WriteLine($"y = {y}");

        }
        break;
    case 3:
        {

            k = 1.57;
            r = 0.75;
            s = 2.15;
            if (Math.Cos(x) == Math.Cos(r * s)) y = (Math.Pow(x, 2) * Math.Exp(2 * k) * k + Math.Log(Math.Abs(r * x)));
            else if (Math.Cos(x) > Math.Cos(r * s)) y = Math.Pow(x, 2 / 3) + Math.Sqrt(Math.Abs(k + r * s * x));
            else y = (Math.Atan(k * x + r * s));
            Console.WriteLine($"y = {y}");
        }
        break;

}
