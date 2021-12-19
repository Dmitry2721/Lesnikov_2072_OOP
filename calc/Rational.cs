using System;
using System.Collections.Generic;
using System.Text;

namespace calc
{
    class Rational
    {
        
        public int Chis;
        public int Znam;

        public Rational()
        {
            Chis = 0;
            Znam = 1;
        }
        public Rational(int Chis, int Znam)
        {
            this.Chis = Chis;
            this.Znam = Znam;
        }
        static public Rational operator +(Rational r1, Rational r2)
        {
            int rChis = r1.Chis * r2.Znam + r2.Chis * r1.Znam;
            int rZnam = r1.Znam * r2.Znam;
            Rational r = new Rational(rChis, rZnam);
            return r;
        }

        static public Rational operator -(Rational r1, Rational r2)
        {
            int resultNum = r1.Chis * r2.Znam - r2.Chis * r1.Znam;
            int resultDel = r1.Znam * r2.Znam;
            Rational r = new Rational(resultNum, resultDel);
            return r;
        }

        static public Rational operator *(Rational r1, Rational r2)
        {
            int resultNum = r1.Chis * r2.Chis;
            int resultDel = r1.Znam * r2.Znam;
            Rational r = new Rational(resultNum, resultDel);
            return r;
        }

        static public Rational operator /(Rational r1, Rational r2)
        {
            int resultNum = r1.Chis*r2.Znam;
            int resultDel = r1.Znam * r2.Chis;
            Rational r = new Rational(resultNum, resultDel);
            return r;
        }

        override public string ToString()
        {
            return Chis + "/" + Znam;
        }

        public void Reduction()
        {
            int m = Math.Abs(Chis);
            int n = Math.Abs(Znam);
            while (m != n)
            {
                if (m > n)
                {
                    m = m - n;
                }
                else
                {
                    n = n - m;
                }
            }
            int nod = n;
            Chis = Chis / nod;
            Znam = Znam / nod;
        }
    }
}
