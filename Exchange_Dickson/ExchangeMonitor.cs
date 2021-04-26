using System;
using System.Collections.Generic;
using System.Text;

namespace Exchange_Dickson
{
    class ExchangeMonitor
    {
        private double total = 0;
        private int loop = 0;
        public double totalUp(string type, double initial)
        {
            if (type=="usd to gbp"|| type == "usd to can" || type == "usd to eur")
            {
                total = initial + total;
            }
            else if (type == "gbp to usd"|| type == "gbp to can" || type == "gbp to eur")
            {
                total = Exchanger.gbptousd(initial) + total;
            }
            else if (type == "can to usd" || type == "can to gbp" || type == "can to eur")
            {
                total = Exchanger.cantousd(initial) + total;
            }
            else if (type == "eur to usd" || type == "eur to gbp" || type == "eur to can")
            {
                total = Exchanger.eurtousd(initial) + total;
            }
            loop++;
            return total;
        }
        public int countLoops()
        {
            return loop;
        }
    }
}
