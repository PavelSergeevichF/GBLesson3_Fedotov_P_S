using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Fedotov_P_S.Properties
{
    struct ComplexStruct
    {
        public int a, b;
        public ComplexStruct(int re, int im)
        {
            a = re;
            b = im;
        }
        public static ComplexStruct operator +(ComplexStruct x, ComplexStruct y)
        {
            return new ComplexStruct(re: x.a+y.a, im: x.b+y.b);
        }
        public static ComplexStruct operator -(ComplexStruct x)
        {
            return new ComplexStruct(re: -x.a, im: -x.b);
        }
        public override string ToString()
        {
            return b>=0 ? $"{a}+{b}i":$"{a}-{-b}i";
        }
    }
    class Complex
    {
        public int a, b;
        public Complex(int re, int im)
        {
            a = re;
            b = im;
        }
        public static Complex operator +(Complex x, Complex y)
        {

            return new Complex(re: x.a + y.a, im: x.b + y.b);
        }

        public static Complex operator -(Complex x, Complex y)
        {
            return new Complex(re: x.a - y.a, im: x.b - y.b);
        }

        public static Complex operator -(Complex x)
        {
            return new Complex(re: -x.a, im: -x.b);
        }


        public override string ToString()
        {
            return b >= 0 ? $"{a} + {b}i" : $"{a} - {-b}i";
        }
    }
}
