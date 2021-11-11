using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormss
{   
    class Triangle
    {
        public double a;//объявляем переменную а
        public double b;//объявляем переменную b
        public double c;//объявляем переменную с
        public double h;//объявляем высоту h

        public Triangle(double A, double B, double C)
        {
            a = A; //а малекькая будет равна А большой , стороны треугольника
            b = B;//b малекькая будет равна B большой , стороны треугольника
            c = C;//c малекькая будет равна C большой , стороны треугольника

        }
        public Triangle(double A, double B, double C,double H)
        {
            a = A;//а малекькая будет равна А большой , стороны треугольника
            b = B;//b малекькая будет равна B большой , стороны треугольника
            c = C;//c малекькая будет равна C большой , стороны треугольника
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

        public double Perimeter()//создаем периметр
        {
            double p = 0;//сначала приравниваем к 0
            p = a + b + c;//периметр равен сумме всех сторон
            return p;//возращаем периметр
        }
        public double Visota()//создаем высоту
        {
            double h = 0;//высота равна 0
            h= a*b/ 2;//чтобы найти высоту надо а умножить на b и делить на 2
            return h;//возращаем h
        }
        public double poluPerimetr()//создаем полупериметр
        {
            double m = 0;//полупериметр будет равен 0
            m = (a+b+c)/2;//чтобы найти полупериметр надо все стороны сложить и разделить на 2 
            return m;//возращаем m
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
                if (a == b && a == c && b == c)//если все true
                    return "равносторонний";
                else if (a == b || a ==c || b == c)//если какое то из значений true 
                    return "равнобедренный";
                else return "разносторонний";
            }
        }


    }
    
}
