using System;
using System.Collections.Generic;
using System.Text;

namespace Exchange_Dickson
{
    static class Exchanger
    {
        public static double usdtogbp(double money)
        {
            double gbp = Math.Round(money * 0.72523, 2);
            return gbp;
        }
        public static double usdtocan(double money)
        {
            double can = Math.Round(money * 1.25427, 2);
            return can;
        }
        public static double usdtoeur(double money)
        {
            double eur = Math.Round(money * 0.83572, 2);
            return eur;
        }
        public static double gbptousd(double cash)
        {
            double usd = Math.Round(cash * 1.37887, 2);
            return usd;
        }
        public static double gbptocan(double cash)
        {
            double can = Math.Round(cash * 1.72947, 2);
            return can;
        }
        public static double gbptoeur(double cash)
        {
            double eur = Math.Round(cash * 1.15195, 2);
            return eur;
        }
        public static double cantousd(double currency)
        {
            double usd = Math.Round(currency * 0.79728, 2);
            return usd;
        }
        public static double cantogbp(double currency)
        {
            double gbp = Math.Round(currency * 0.57848, 2);
            return gbp;
        }
        public static double cantoeur(double currency)
        {
            double eur = Math.Round(currency * 0.66645, 2);
            return eur;
        }
        public static double eurtousd(double green)
        {
            double usd = Math.Round(green * 1.19648, 2);
            return usd;
        }
        public static double eurtogbp(double green)
        {
            double gbp = Math.Round(green * 0.86826, 2);
            return gbp;
        }
        public static double eurtocan(double green)
        {
            double can = Math.Round(green * 1.5004, 2);
            return can;
        }
    }
}
