using System;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(1, 2);
            Complex b = new Complex(3, 4);

            Complex c = a + b;
            Console.WriteLine($"Zbrajanje: ({a.Real} + {a.Imaginary}*i) + ({b.Real} + {b.Imaginary}*i) = {c.Real} + {c.Imaginary}*i");

            Complex d = new Complex(3, 4);
            Complex e = new Complex(2, 1);

            c = d - e;
            Console.WriteLine($"Oduzimanje: ({d.Real} + {d.Imaginary}*i) - ({e.Real} + {e.Imaginary}*i) = {c.Real} + {c.Imaginary}*i");

            c = a * b;
            Console.WriteLine($"Množenje: ({a.Real} + {a.Imaginary}*i) * ({b.Real} + {b.Imaginary}*i) = {c.Real} + {c.Imaginary}*i");

            Complex f = new Complex(5, 5);
            Complex g = new Complex(1, 2);
            c = f / g;
            Console.WriteLine($"Množenje: ({f.Real} + {f.Imaginary}*i) / ({g.Real} + {g.Imaginary}*i) = {c.Real} + {c.Imaginary}*i");



            Complex compl = 5;
            Console.WriteLine($"Operator implicitne pretvorbe: ({compl.Real} + {compl.Imaginary}*i)");



            var roots1 = Complex.Sqrt(-4);

            Console.WriteLine($"Prvi korijen: ({roots1[0].Real} + {roots1[0].Imaginary}*i)");
            Console.WriteLine($"Prvi korijen: ({roots1[0].ToString()})");

            Console.WriteLine($"Drugi korijen: ({roots1[1].Real} + {roots1[1].Imaginary}*i)");
            Console.WriteLine($"Prvi korijen: ({roots1[1].ToString()})");

            var roots2 = Complex.Sqrt(4);

            Console.WriteLine($"Prvi korijen: ({roots2[0].Real} + {roots2[0].Imaginary}*i)");
            Console.WriteLine($"Prvi korijen: ({roots2[0].ToString()})");
            Console.WriteLine($"Prvi korijen: ({roots2[1].Real} + {roots2[1].Imaginary}*i)");
            Console.WriteLine($"Prvi korijen: ({roots2[1].ToString()})");

        }
    }
}
