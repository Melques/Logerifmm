using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logarifm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_sim_Click(object sender, EventArgs e)
        {/*
            class Program
        {
            
            private static double Simpson(Func<double, double> f, double a, double b, int n)
            {
                var h = (b - a) / n;
                var sum1 = 0d;
                var sum2 = 0d;
                for (var k = 1; k <= n; k++)
                {
                    var xk = a + k * h;
                    if (k <= n - 1)
                    {
                        sum1 += f(xk);
                    }

                    var xk_1 = a + (k - 1) * h;
                    sum2 += f((xk + xk_1) / 2);
                }

                var result = h / 3d * (1d / 2d * f(a) + sum1 + 2 * sum2 + 1d / 2d * f(b));
                return result;
            }

            static void Main(string[] args)
            {
                
                double f(double x) => x / (x - 1);

                var result = Simpson(f, 4, 10, 1000);
                Console.WriteLine("S = {0}", result);

                Console.ReadKey();
            }
        }*/
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            /*
class Program
{
    
    static double Abs(double x)
    {
        return (x < 0) ? -x : x;
    }

    
    static int Sign(double x)
    {
        return (x < 0) ? -1 : 1;
    }

    
    static double BisectionMethod(Func<double, double> function, double a, double b, double precision = 1e-10)
    {
        while (true)
        {
            var t = (a + b) / 2;

            if (function(t) == 0.0 || Abs(b - a) < Abs(precision))
            {
                return t;
            }

            if (Sign(function(t)) == Sign(function(a)))
            {
                a = t;
            }
            else
            {
                b = t;
            }
        }
    }

    static void Main(string[] args)
    {
        
        double f(double x) => 3 * Math.Pow(x, 2) - 6 * x + 1;

        Console.WriteLine("3x^2 - 6x + 1");
        Console.Write("Введите начало отрезка: ");
        var a = double.Parse(Console.ReadLine());
        Console.Write("Введите конец отрезка: ");
        var b = double.Parse(Console.ReadLine());
        Console.Write("Введите точность вычислений: ");
        var eps = double.Parse(Console.ReadLine());

        var result = BisectionMethod(f, a, b, eps);
        Console.WriteLine("x = {0}\r\nf({0}) = {1}", result, f(result));
        Console.ReadKey();
    }
}*/
        }

        private void btn_sqr_Click(object sender, EventArgs e)
        {
            /*class Program
{
    static double LeftRectangle(Func<double, double> f, double a, double b, int n)
    {
        var h = (b - a) / n;
        var sum = 0d;
        for(var i = 0; i <= n-1; i++)
        {
            var x = a + i * h;
            sum += f(x);
        }

        var result = h * sum;
        return result;
    }

    static double RightRectangle(Func<double, double> f, double a, double b, int n)
    {
        var h = (b - a) / n;
        var sum = 0d;
        for (var i = 1; i <= n; i++)
        {
            var x = a + i * h;
            sum += f(x);
        }

        var result = h * sum;
        return result;
    }

    static double CentralRectangle(Func<double, double> f, double a, double b, int n)
    {
        var h = (b - a) / n;
        var sum = (f(a) + f(b)) / 2;
        for (var i = 1; i < n; i++)
        {
            var x = a + h * i;
            sum += f(x);
        }

        var result = h * sum;
        return result;
    }

    static void Main(string[] args)
    {
        
        double f(double x) => x / (x - 1);

        var result = LeftRectangle(f, 4, 10, 1000);
        Console.WriteLine("Формула левых прямоугольников: {0}", result);
        result = RightRectangle(f, 4, 10, 1000);
        Console.WriteLine("Формула правых прямоугольников: {0}", result);
        result = CentralRectangle(f, 4, 10, 1000);
        Console.WriteLine("Формула средних прямоугольников: {0}", result);

        Console.ReadKey();
    }
}*/
        }

        private void textSim_TextChanged(object sender, EventArgs e)
        {
            /**/
        }

        private void text_sqr_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_del_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
