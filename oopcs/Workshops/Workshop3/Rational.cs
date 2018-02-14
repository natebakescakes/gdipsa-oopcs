using System;

namespace Workshops.Workshop3
{
    public class Rational : IEquatable<Rational>
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Rational(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            Reduce(); // Reduce on instantiation.
        }

        private void Reduce()
        {
            int gcd = GCD(Numerator, Denominator);

            if (gcd != 1)
            {
                Numerator /= gcd;
                Denominator /= gcd;
            }
        }

        private int GCD (int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a == 0 ? b : a;
        }

        public Rational Add(Rational other)
        {
            int d = this.Denominator * other.Denominator;
            int n = (this.Numerator * other.Denominator) + (other.Numerator * this.Denominator);

            Rational newRational = new Rational(n, d);
            newRational.Reduce();

            return newRational;
        }

        public Rational Subtract(Rational other)
        {
            int d = this.Denominator * other.Denominator;
            int n = (this.Numerator * other.Denominator) - (other.Numerator * this.Denominator);

            Rational newRational = new Rational(n, d);
            newRational.Reduce();

            return newRational;
        }

        public Rational Multiply(Rational other)
        {
            int n = this.Numerator * other.Numerator;
            int d = this.Denominator * other.Denominator;

            Rational newRational = new Rational(n, d);
            newRational.Reduce();

            return newRational;
        }

        public Rational Divide(Rational other)
        {
            int n = this.Numerator * other.Denominator;
            int d = this.Denominator * other.Numerator;

            Rational newRational = new Rational(n, d);
            newRational.Reduce();

            return newRational;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        #region Equality Code Block
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            var toCompareWith = obj as Rational;

            return Numerator == toCompareWith.Numerator && Denominator == toCompareWith.Denominator;
        }

        public override int GetHashCode()
        {
            return Numerator.GetHashCode() ^ Denominator.GetHashCode();
        }

        public bool Equals(Rational other)
        {
            return this.Equals(other);
        }
        #endregion

        #region Operator Code Block
        public static bool operator ==(Rational r1, Rational r2)
        {
            return r1.Equals(r2);
        }

        public static bool operator != (Rational r1, Rational r2)
        {
            return !r1.Equals(r2);
        }

        public static Rational operator +(Rational r1, Rational r2)
        {
            return r1.Add(r2);
        }

        public static Rational operator -(Rational r1, Rational r2)
        {
            return r1.Subtract(r2);
        }

        public static Rational operator *(Rational r1, Rational r2)
        {
            return r1.Multiply(r2);
        }

        public static Rational operator /(Rational r1, Rational r2)
        {
            return r1.Divide(r2);
        }
        #endregion
    }
}
