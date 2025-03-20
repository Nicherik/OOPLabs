using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.Classes
{
    public class RationalNumbers
    {
        public int Numerator { get; }
        public int Denominator { get; }


        public RationalNumbers() { }
        public RationalNumbers(int numerator, int denominator)
        {
            if (denominator != 0)
            {
                Numerator = numerator;
                Denominator = denominator;
            }
            else
            {

                Console.WriteLine("Denominator can't be 0!");
                Environment.Exit(1);
            }
        }


        public override string ToString()
        {
            string nume = Numerator.ToString();
            string den = Denominator.ToString();
            return nume + "/" + den;
        }
        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }


        private static RationalNumbers Simplifited(RationalNumbers num1)
        {
            int num = num1.Numerator;
            int den = num1.Denominator;

            int gcd1 = GCD(num, den);

            if (den < 0 && num >= 0)
            {
                den = -den;
                num = -num;
            }

            if (den < 0 && num >= 0)
            {
                den = -den;
                num = -num;
            }
            return new RationalNumbers(num / gcd1, den / gcd1);
        }

        public string toString()
        {
            return string.Format("{0}/{1}", Numerator, Denominator);
        }

        public static RationalNumbers operator +(RationalNumbers number1, RationalNumbers number2)
        {

            int num = number1.Numerator * number2.Denominator + number1.Denominator * number2.Numerator;
            int den = number1.Denominator * number2.Denominator;
            int gcd = GCD(num, den);

            return new RationalNumbers(num / gcd, den / gcd);

        }

        public static RationalNumbers operator -(RationalNumbers number1, RationalNumbers number2)
        {



            int num = number1.Numerator * number2.Denominator - number1.Denominator * number2.Numerator;
            int den = number1.Denominator * number2.Denominator;
            int gcd = GCD(num, den);
            return new RationalNumbers(num / gcd, den / gcd);
        }

        public static RationalNumbers operator *(RationalNumbers number1, RationalNumbers number2)
        {



            int num = number1.Numerator * number2.Numerator;
            int den = number1.Denominator * number2.Denominator;
            int gcd = GCD(num, den);

            return new RationalNumbers(num / gcd, den / gcd);
        }



        public static RationalNumbers operator /(RationalNumbers number1, RationalNumbers number2)
        {



            int num = number1.Numerator * number2.Denominator;
            int den = number1.Denominator * number2.Numerator;
            int gcd = GCD(num, den);
            return new RationalNumbers(num / gcd, den / gcd);
        }
        public static RationalNumbers operator -(RationalNumbers num1)
        {
            int num = num1.Numerator;
            int den = num1.Denominator;
            int gcd = GCD(num, den);
            return new RationalNumbers(-num1.Numerator / gcd, num1.Denominator / gcd);
        }

        public static bool operator ==(RationalNumbers num1, RationalNumbers num2)
        {
            RationalNumbers num;
            RationalNumbers other_num;
            num = Simplifited(num1);
            other_num = Simplifited(num2);


            if (num.Numerator == other_num.Numerator && num.Denominator == other_num.Denominator)
            {

                return true;
            }
            return false;
        }
        public static bool operator !=(RationalNumbers num1, RationalNumbers num2)
        {
            RationalNumbers num;
            RationalNumbers other_num;
            num = Simplifited(num1);
            other_num = Simplifited(num2);


            if (num.Numerator != other_num.Numerator || num.Denominator != other_num.Denominator)
            {

                return true;
            }
            return false;
        }

        public static bool operator >(RationalNumbers num1, RationalNumbers num2)
        {

            double num = num1.Numerator / num1.Denominator;
            double other_num = num2.Numerator / num2.Denominator;
            if (num > other_num)
                return true;
            return false;

        }

        public static bool operator <(RationalNumbers num1, RationalNumbers num2)
        {

            double num = num1.Numerator / num1.Denominator;
            double other_num = num2.Numerator / num2.Denominator;
            if (num < other_num)
                return true;
            return false;

        }

        public static bool operator >=(RationalNumbers num1, RationalNumbers num2)
        {

            double num = num1.Numerator / num1.Denominator;
            double other_num = num2.Numerator / num2.Denominator;
            if (num >= other_num)
                return true;
            return false;

        }

        public static bool operator <=(RationalNumbers num1, RationalNumbers num2)
        {

            double num = num1.Numerator / num1.Denominator;
            double other_num = num2.Numerator / num2.Denominator;
            if (num <= other_num)
                return true;
            return false;

        }
    }

}

