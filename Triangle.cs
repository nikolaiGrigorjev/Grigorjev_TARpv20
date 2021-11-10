using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormss
{   
    class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double h;

        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        
        }
        public Triangle(double A, double B, double C,double H)
        {
            a = A;
            b = B;
            c = C;
            h = H;

        }
        public string outputA()
        {
            return Convert.ToString(a);
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }

        public double Perimeter()
        {
            double p = 0;
            p = a + b + c;
            return p;
        }
        public double Visota()
        {
            double h = 0;
            h= a*b/ 2;
            return h;
        }
        public double poluPerimetr()
        {
            double m = 0;
            m = a+b+c/2;
            return m;
        }
        public double vpisanajaOkruznost()
        {
            double s = 0;
            double p = 0;
            double r = 0;
            r = s / p;
            return r;
        }
        public double opisanajaOkruznost()
        {
            double s = 0;
            double p = 0;
            double q = 0;
            q = a * b * c / 4 * s;
            return q;
        }
        public double Surface()
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }
        public double GetSetA
        {
            get
            { return a; }
            set
            { a = value; }
        }
        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC
        {
            get
            { return c; }
            set
            { c = value; }
        }
        public bool ExistTriangle
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b))
                return false;
                else return true;
            }
        }
        public string TriangleType
        {
            get

            {
                if (a == b && a == c && b == c)
                    return "равносторонний";
                else if (a == b || a ==c || b == c)
                    return "равнобедренный";
                else return "разносторонний";
            }
        }


    }
    
}
