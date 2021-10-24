using System;
using System.Collections.Generic;
using System.Text;

namespace Complex
{
    struct Complex
    {
        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public Complex(double real)
        {
            this.real = real;
            imaginary = 0d;
        }

        public double Real
        {
            get { return real; }
        }

        public double Imaginary
        {
            get { return imaginary; }
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.real + b.real, a.imaginary + b.imaginary); 
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex((c1.Real * c2.Real) - (c1.Imaginary * c2.Imaginary), c2.Real * c1.Imaginary + c1.Real * c2.Imaginary);
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            return new Complex(((c1.Real * c2.Real) + (c1.Imaginary * c2.Imaginary)) / (Math.Pow(c2.Real, 2) + Math.Pow(c2.Imaginary, 2)), (c2.Real * c1.Imaginary - c1.Real * c2.Imaginary) / (Math.Pow(c2.Real, 2) + Math.Pow(c2.Imaginary, 2)));
        }

        public static implicit operator Complex(double number)
        {
            return new Complex(number);
        }

        public static Complex[] Sqrt(double number) 
        {
            if (number >= 0.0d)
            {
                return new Complex[] { new Complex(Math.Sqrt(number)), new Complex(-Math.Sqrt(number)) };
            }
            
            return new Complex[] { new Complex(0, Math.Sqrt(-1 * number)), new Complex(0, -1 * Math.Sqrt(-1 * number)) };
        }

        public override string ToString()
        {
            return string.Format("{0} + {1}i", this.real, this.imaginary);
        }

        private double real;
        private double imaginary;
    }
}
