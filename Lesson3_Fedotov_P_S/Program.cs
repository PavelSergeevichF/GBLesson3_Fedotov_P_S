using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Fedotov_P_S
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            do
            {
                Console.WriteLine("Использовать класс или структкру введите соответственно c/s");
                str = Console.ReadLine();
            }
            while (str != "c" || str != "s");
            switch(str)
            {
                case "c":
                    Properties.Complex z1 = new Properties.Complex(re: 1, im: 33);
                    break;
                case "s":
                    break;
            }
            Properties.Class2.SumOddNumbers();
        }
    }
}
