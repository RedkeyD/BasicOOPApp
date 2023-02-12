using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalc
{
    public class MyCalc1
    {
        protected int a;
        protected double b;

        public MyCalc1()
        {

        }
        public MyCalc1(int a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double findC()
        {
            double c = (a + b) / (a - 1);
            return c;
        }
    }

    public class MyCalc2 : MyCalc1
    {
        protected double d;

        public MyCalc2()
        {
        }

        public MyCalc2(double d, double b, int a)
        {
            this.d = d;
            this.b = b;
            this.a = a;
        }

        public double findC2()
        {
            double c2;
            if (d > a)
            {
                c2 = a + b - d;
                return c2;
            }
            else
            {
                c2 = a - b;
                return c2;
            }
        }
    }
    public class flyingObject 
    {
        private double length, speed;
        private string name;
        
        public flyingObject() 
        {
            length = 0;
            speed = 0;
            name = " ";
        }
        public flyingObject(double length, double speed, string name) 
        { 
            this.length = length;
            this.speed = speed;
            this.name = name;
        }

        public double inOurUnit() 
        {
            double ourUnit = speed/ length;
            return ourUnit;
        }
    }
}
