using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите число a");
            //Console.WriteLine("Введите число a");
            //Console.WriteLine("Введите число a");
            //int a = int.Parse(Console.ReadLine());
            //int a = int.Parse(Console.ReadLine());
            //int a = int.Parse(Console.R12321eadLine());
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Введите число b");
            //Console.WriteLine("Введите число b");
            //Console.WriteLine("Введите число b");
            //Console.WriteLine("Введите число b");
            //int b = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine("a + b = " + (a + b));
            //Console.WriteLine("a + b = " + (a + b));
            //Console.WriteLine("a + b = " + (a + b));
            //Console.WritesdLine("a + b = " + (a + b));
            //Console.ReadLine();
            //test comment for push
            //
            //Дано значение числа pi, которое равно 3,141592653 и значение числа Эйлера е, которое равно 2,7182818284 590452.
            //Создайте две переменные, присвойте им значения числа pi и числа е и выведите их на экран без потери точности.
            decimal pi = 3.141592653m;
            double e = 2.7182818284590452;
            Console.WriteLine(e);
            Console.WriteLine(pi);

            //Создайте три строковые переменные и присвойте им значения: "\nмоя строка 1”; "\tмоя строка 2”; "\aмоя строка 3".
            //Выведите значение каждой переменной на экран.Какие отличия вы увидели? Сделайте выводы.
            string st1 = "\nмоя строка 1";
            string st2 = "\tмоя строка 2";
            string st3 = "\aмоя строка 3";
            Console.WriteLine($"{ st1},{ st2},{ st3}");
            //инетрполяция

            //  Используя Visual Studio, создайте проект по шаблону Console Application. Создайте константу с именем -pi(число π «пи»), создайте переменную радиус с именем – r.
            //   Используя формулу πR2, вычислите площадь круга и выведите результат на экран.
            //double pi1 = 3.14;
            //Console.WriteLine("Введите радиус круга");
            //double r = double.Parse(Console.ReadLine());
            //double s =  r * r * pi1;
            //Console.WriteLine(s);
            //Напишите программу расчета объема – V и площади поверхности – S цилиндра. 
            //Объем V цилиндра радиусом – R и высотой – h, вычисляется по формуле: V = πR2h.
            //Площадь S поверхности цилиндра вычисляется по формуле: S = 2πR(R + h).
            Console.WriteLine("введите радиус цилндра");
            double rc = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту цилиндра");
            double hc = double.Parse(Console.ReadLine());
            double sc = 2 * Math.PI * rc * (rc + hc);
            Console.WriteLine(sc);
            double v = Math.PI* rc*2*hc;
            Console.WriteLine(v);
            double  a = double.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine(1);
                    break;
                case 2:
                case 3:
                    Console.WriteLine(2);
                    break;
                case 4:
                    Console.WriteLine(4);
                    break;
                default:
                    Console.WriteLine("Дадад");
                    break;
            }

            Console.ReadLine();


        }
    }
}
