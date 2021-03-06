﻿using info.lundin.math;
//using MathParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using parserDecimal.Parser;


namespace WindowsFormsApplication1
{
    

    public class GoldenSM: Form1
    {
//public  ExpressionParser parser = new ExpressionParser();
        double rr = (Math.Pow(5, 0.5) - 1) / 2;
    
        Decimal x1 = 0, x2 = 0;
        Decimal fx1 = 0, fx2 = 0, abs = 0;
        int k;//текущая итерация
        string fxp;
        //public ExpressionParser parser = new ExpressionParser();
        public Decimal Function(Decimal x1)//функция 
        {
            Computer computer = new Computer();
           // ((DoubleValue)parser.Values["x"]).Value = x1;          
            //return parser.Parse(fxp);
           return computer.Compute(fxp, x1);
            // Math.Pow(x, 3) + Math.Pow(x, 2) - 6 * (x) - 6;//функция   
        }
        public void fparse(string f)//принимаю функцию.
        {
            fxp = f;
        
        }
        public String[] GoldenIterationMax(Decimal x, Decimal a, Decimal b, Decimal tol, int k_max, string f)
        {
            Decimal r = (Decimal) rr;
            fparse(f);
          //  parser.Values.Add("x", a);
            String[] it = new String[500];// строка информации по итерациям
            x1 = a + (1 - r) * (b - a);  
            fx1 = Function(x1);
            x2 = a + r * (b - a);
            fx2 = Function(x2);
            k = 0;
            it[0] = it[0] + "x1 = a + (1 - r) * (b - a)=  " + x1 + "\n";
            it[0] = it[0] + "fx1= " + fx1 + "\n";
            it[0] = it[0] + "x2 = a + r * (b - a)=  " + x2 + "\n";
            it[0] = it[0] + "fx2= " + fx2 + "\n";
            it[0] = it[0] + "k= " + k + "\n\n";
            it[0] = it[0] + "Итерации: \n";

            do
            {
                k += 1;
               it[k - 1] = it[k - 1] + "k=k + 1= " + k + "\n";
               it[k - 1] = it[k - 1] + "IF fx1 < fx2" + "  ";
                if (fx1 < fx2)
                {
                   it[k - 1] = it[k - 1] + "True \n";
                    a = x1;
                    x1 = x2;
                    fx1 = fx2;
                    x2 = a + r * (b - a);
                    fx2 = Function(x2);
                  it[k - 1] = it[k - 1] + "a=x1= " + a + "\n";
                    it[k - 1] = it[k - 1] + "x1=x2= " + x1 + "\n";
                    it[k - 1] = it[k - 1] + "fx1=fx2= " + fx1 + "\n";
                    it[k - 1] = it[k - 1] + "x2= a + r * (b - a)= " + x2 + "\n";
                    it[k - 1] = it[k - 1] + "fx2= " + fx2 + "\n ";
                }
                else
                {
                   it[k - 1] = it[k - 1] + "False \n";
                    b = x2;
                    x2 = x1;
                    fx2 = fx1;
                    x1 = a + (1 - r) * (b - a);
                    fx1 = Function(x1);
                   it[k - 1] = it[k - 1] + "b=x2= " + b + "\n";
                    it[k - 1] = it[k - 1] + "x2=x1= " + x2 + "\n";
                    it[k - 1] = it[k - 1] + "fx2=fx1= " + fx2 + "\n";
                    it[k - 1] = it[k - 1] + "x1 = a + (1 - r) * (b - a)= " + x1 + "\n";
                    it[k - 1] = it[k - 1] + "fx1= " + fx1 + "\n";
                }
                if ( Math.Abs(b - a)<= tol)
                  it[k - 1] = it[k - 1] + "IF  k < k_max  True.\n \n ";
            }
            while (k < k_max && (Math.Abs(b - a) > tol));
            it[k - 1] = it[k - 1] + "IF  k < k_max " + "False.\n";
            it[k - 1] = it[k - 1] + " Выходные данные: \n ";
            it[k - 1] = it[k - 1] + "x1= " + x1 + "\n ";
            it[k - 1] = it[k - 1] + "fx1= " + fx1 + "\n ";
            it[k - 1] = it[k - 1] + "k= " + k + "\n ";
            it[k - 1] = it[k - 1] + "ABS(b-a)= " + Math.Abs(b - a) + " Не играет роли, так как ограничение это k_max.";
            abs = Math.Abs(b - a);
            return it;
        }
        public int k_iner()
        {
            return k;
        }
        public Decimal x1out()
    {
    return x1;
    }
        public Decimal fx1out()
        {
            return fx1;
        }
        public Decimal absab()
        {
            return abs;
        }
        public String[] GoldenIterationMin(Decimal x, Decimal a, Decimal b, Decimal tol, int k_max, string f)
        {
            Decimal r = (Decimal)rr;
            fparse(f);
            //parser.Values.Add("x", x1);
            String[] it = new String[500];// строка информации по итерациям
            x1 = a + (1 - r) * (b - a);
            fx1 = Function(x1);
            x2 = a + r * (b - a);
            fx2 = Function(x2);
            k = 0;
            it[0] = it[0] + "x1 = a + (1 - r) * (b - a)=  " + x1 + "\n";
            it[0] = it[0] + "fx1= " + fx1 + "\n";
            it[0] = it[0] + "x2 = a + r * (b - a)=  " + x2 + "\n";
            it[0] = it[0] + "fx2= " + fx2 + "\n";
            it[0] = it[0] + "k= " + k + "\n\n";
            it[0] = it[0] + "Итерации: \n";
            do
            {
                k += 1;
                it[k - 1] = it[k - 1] + "k=k + 1= " + k + "\n";
                it[k - 1] = it[k - 1] + "IF fx1 > fx2" + "  ";
                if (fx1 > fx2)
                {
                    it[k - 1] = it[k - 1] + "True \n";
                    a = x1;
                    x1 = x2;
                    fx1 = fx2;
                    x2 = a + r * (b - a);
                    fx2 = Function(x2);
                    it[k - 1] = it[k - 1] + "a=x1= " + a + "\n";
                    it[k - 1] = it[k - 1] + "x1=x2= " + x1 + "\n";
                    it[k - 1] = it[k - 1] + "fx1=fx2= " + fx1 + "\n";
                    it[k - 1] = it[k - 1] + "x2 = a + r * (b - a)= " + x2 + "\n";
                    it[k - 1] = it[k - 1] + "fx2= " + fx2 + "\n ";
                }
                else
                {
                    it[k - 1] = it[k - 1] + "False \n";
                    b = x2;
                    x2 = x1;
                    fx2 = fx1;
                    x1 = a + (1 - r) * (b - a);
                    fx1 = Function(x1);
                    it[k - 1] = it[k - 1] + "b=x2= " + b + "\n";
                    it[k - 1] = it[k - 1] + "x2=x1= " + x2 + "\n";
                    it[k - 1] = it[k - 1] + "fx2=fx1= " + fx2 + "\n";
                    it[k - 1] = it[k - 1] + "x1= a + (1 - r) * (b - a)= " + x1 + "\n";
                    it[k - 1] = it[k - 1] + "fx1= " + fx1 + "\n ";
                }
                if (k < k_max)
                    it[k - 1] = it[k - 1] + "IF  k < k_max  True.\n \n ";
            }
            while (k < k_max && Math.Abs(b - a) > tol );
            it[k - 1] = it[k - 1] + "IF  k < k_max " + "False.\n";
            it[k - 1] = it[k - 1] + "Выходные данные: \n ";
            it[k - 1] = it[k - 1] + "x1= " + x1 + "\n ";
            it[k - 1] = it[k - 1] + "fx1= " + fx1 + "\n ";
            it[k - 1] = it[k - 1] + "k= " + k + "\n ";
            it[k - 1] = it[k - 1] + "ABS(b-a)= " + Math.Abs(b - a) + " Не играет роли, так как ограничение это k_max.";
            abs = Math.Abs(b - a);
            return it;
        }
    }
}

