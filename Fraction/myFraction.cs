using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class myFraction
    {
        private int numerator; // числит
        private int denominator; // знаменат
        public myFraction()
        {
            this.numerator = 0;
            this.denominator = 1;
        }

        public myFraction(int num)
        {
            this.numerator = num;
            this.denominator = num;
        }

        public myFraction(int num1, int num2)
        {
            this.numerator = num1;
            this.denominator = num2;
        }

        public string ToString()
        {
            return this.numerator + "." + this.denominator;
        }

        public bool isTrueFraction()
        {
            if (this.numerator < this.denominator)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }

        public int IntPart()
        {
            if (this.isTrueFraction())
                return 0;
            else
            {
                return this.numerator / this.denominator;
            }
        }

        public myFraction Multi(myFraction other)
        {
            myFraction result = new myFraction(1, 1);
            result.numerator = this.numerator * other.numerator;
            result.denominator = this.denominator * other.denominator;
            return result;
        }

        public myFraction Amount(myFraction other)
        {
            myFraction result = new myFraction(0, 0);
            if (this.denominator == other.denominator)
            {
                result.numerator = this.numerator + other.numerator;
                result.denominator = this.denominator;
            }
            if (this.denominator != other.denominator)
            {
                result.numerator = this.numerator * other.denominator + other.numerator * this.denominator;
                result.denominator = this.denominator * other.denominator;
            }
            return result;
        }
        public static implicit operator double(myFraction a)
        {
            return (double)a.numerator / (double)a.denominator;
        }
    }
}
