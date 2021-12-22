using System;
using Kol_station;

namespace START
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите площадь района обслуживания: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите площадь покрытия базовой станции");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффицент застройки:");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус первой базовой станции: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус второй базовой станции: ");
            double e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус третей базовой станции: ");
            double f = Convert.ToDouble(Console.ReadLine());
            if (c == 0)
            {
                Console.WriteLine("Ошибка! Коэффицент застройки должен быть больше 0");
            }
            Station start = new Station();
            int Result = start.Znachenia(a,b,c,d,e,f);
        }
    }
    
}
