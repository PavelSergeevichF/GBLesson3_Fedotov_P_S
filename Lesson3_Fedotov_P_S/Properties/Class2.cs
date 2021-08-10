using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Fedotov_P_S.Properties
{
    class Class2
    {
        static public void SumOddNumbers()
        {
            double result = 0;
            double num = 0;
            do
            {
                num = InputNum();
                if(num<0)
                {
                    Console.WriteLine("Число отрицательное.");
                }
                else 
                {
                    if(num%2==0)
                    {
                        Console.WriteLine("Число четное.");
                    }
                    else 
                    {
                        Console.WriteLine("Число нечетное. Данное число складывается");
                        result += num;
                    }
                }
            } while (num != 0);
            Console.WriteLine("Сумма нечетных чисел ровна "+result);
            Console.ReadLine();
        }
        static double InputNum()
        {
            double number = 0;
            string str = String.Empty;
            bool successs = false;
            do
            {
                Console.WriteLine("Введите число, для выхода введите 0.");
                str = Console.ReadLine();
                successs = double.TryParse(str,out number);
                if (!successs) Console.WriteLine("Введите корректное значение! Для завершения введите 0.");
            } while (!successs);
            return number;
        }
    }
}
