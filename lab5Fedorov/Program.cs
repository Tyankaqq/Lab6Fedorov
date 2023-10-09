//using System.ComponentModel.Design;
//using System.Security.Cryptography.X509Certificates;
//using System.Transactions;

//Console.Write("Введите a:");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите b:");
//double b = double.Parse(Console.ReadLine());
//Console.Write("Введите c:");
//double c = double.Parse(Console.ReadLine());


//if (a != 0)
//{
//    double d = b * b - 4 * a * c;                                                   
//    if (d > 0)
//    {
//        double x1 = (-b + Math.Sqrt(d)) / 2 * a;
//        double x2 = (-b + Math.Sqrt(d)) / 2 * a;
//        Console.WriteLine($"x1 = {x1:F2} x2 = {x2:F2}");
//    }
//    else if (d == 0)
//    {
//        double x = -b / (2 * a);
//        Console.WriteLine($"x = {x:F2}");
//    }
//    else Console.WriteLine("Нет корней");
//}
//else Console.WriteLine("Линейное уравнение");



//using System.ComponentModel.Design;
//using System.Runtime.InteropServices;

//Console.Write("Введите сумму:");
//double rub = double.Parse(Console.ReadLine());
//if(rub%100>10&&rub%100<15) Console.WriteLine(rub + "Рублей");
//else
//switch (rub%10)
//{
//    case 1:
//        Console.WriteLine(rub + "Рубль"); break;
//        case 2: case 3: case 4: Console.WriteLine(rub + "Рубля"); break;
//        default:
//            Console.WriteLine(rub + "Рублей"); break;

//} 