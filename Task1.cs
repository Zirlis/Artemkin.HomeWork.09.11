using System;

class Task1
{
    //1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. 
    //Продемонстрировать работу структуры;
    //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;

    internal static void ComplexExample()
    {
        Complex complex = new Complex();
        complex.im = 4;
        complex.re = 4;

        Complex complex2 = new Complex();
        complex2.im = 2;
        complex2.re = 2;

        Console.WriteLine(complex.Minus(complex2).ToMinusString());
        Console.WriteLine(complex.Multiply(complex2).ToMultiplyString());
    }

    class Complex
    {
        public double im;
        public double re;

        public Complex Plus(Complex x2)
        {
            Complex result = new Complex();

            result.im = x2.im + im;
            result.re = x2.re + re;

            return result;
        }

        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im - im;
            x3.re = x2.re - re;
            return x3;
        }

        public Complex Multiply(Complex com)
        {
            Complex result = new Complex();
            result.im = com.im * im;
            result.re = com.re * re;
            return result;
        }

        public string ToMinusString()
        {
            return re + " - " + -im + "i";
        }

        public string ToMultiplyString()
        {
            return re + " * " + im + "i";
        }
    }
}

