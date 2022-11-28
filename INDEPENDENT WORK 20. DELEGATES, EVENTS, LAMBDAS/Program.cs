using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace INDEPENDENT_WORK_20.DELEGATES__EVENTS__LAMBDAS
{
    class Program
    {
        static double GetLenght (double r)
        {
            double d = 2 * Math.PI * Math.Abs(r);
            Console.WriteLine("Длина окружности равна {0:f2}",d);
            return d;
        }
        static double GetSquare(double r)
        {
            double s = Math.PI * Math.Pow(r,2);
            Console.WriteLine("Площадь окружности равна {0:f2}",s);
            return s;
        }
        static double GetVolume(double r)
        {
            double v =4.0/3* Math.PI * Math.Pow(Math.Abs(r),3);
            Console.WriteLine("Объем шара равен {0:f2}",v);
            return v;
        }

        delegate double MyDelegate(double r);

        static void Main(string[] args)
        {
            MyDelegate myDelegate = GetLenght;
            myDelegate += GetSquare;
            myDelegate += GetVolume;
            myDelegate(2);
            Console.ReadKey();
        }
    }
}
