using System;

namespace Fraction
{
    struct Fraction
    {
        private readonly int _denominator;
        private readonly int _numerator;

        public Fraction(int numerator, int denominator)
        {
            if(denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be 0", nameof(denominator));
            }
            _denominator = denominator;
            _numerator = numerator;
        }

        public static Fraction operator +(Fraction a)
            => a;
        public static Fraction operator -(Fraction a) 
            => new Fraction(-a._numerator, a._denominator);
        public static Fraction operator +(Fraction a, Fraction b) 
            => new Fraction(a._numerator * b._denominator + b._numerator * a._denominator, a._denominator * b._denominator);
        public static Fraction operator -(Fraction a, Fraction b) 
            => a + (-b);
        public static Fraction operator *(Fraction a, Fraction b) 
            => new Fraction(a._numerator * b._numerator, a._denominator * b._denominator);
        public static Fraction operator /(Fraction a, Fraction b)
            => new Fraction(a._numerator * b._denominator, a._denominator * b._numerator);
        public static Fraction operator %(Fraction a, int percentage)
            => a * new Fraction(percentage,100);
        public static Fraction operator ^(Fraction a,int n)
        {
            int num = 1;
            int den = 1;
            for (int i = 0; i < n; i++)
            {
                num *= a._numerator;
                den *= a._denominator;
            }
            return new Fraction(num,den);
        }
        public static bool operator >(Fraction a, Fraction b)
            => (a._numerator/a._denominator > b._numerator/b._denominator);
        public static bool operator <(Fraction a, Fraction b)
            => (a._numerator / a._denominator < b._numerator / b._denominator);
        public static bool operator ==(Fraction a, Fraction b)
            => (a._numerator / a._denominator == b._numerator / b._denominator);
        public static bool operator !=(Fraction a, Fraction b)
            => (a._numerator / a._denominator != b._numerator / b._denominator);
        public static bool operator <=(Fraction a, Fraction b)
            => (a < b || a == b);
        public static bool operator >=(Fraction a, Fraction b)
            => (a > b || a == b);
        public static bool operator true(Fraction a)
            => (a._numerator != a._denominator);
        public static bool operator false(Fraction a)
            => (a._numerator == a._denominator);
        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }

    }
}
