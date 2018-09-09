using Bibox.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibox
{
    class Program
    {
        static void Main(string[] args)
        {
            var CPC = new Token(1, "CPC", "CPChain");
            var BTC = new Token(2, "BTC", "Bitcoin");
            var ETH = new Token(3, "ETH", "Ethereum");

            var CPC_BTC = new Pair(1, CPC, BTC);
            var ETH_BTC = new Pair(2, ETH, BTC);
            var CPC_ETH = new Pair(3, CPC, ETH);
            var revenue = 0m;
            while (true)
            {
                try { 
                var rCPC_BTC = Command.GetAsksAndBids(CPC_BTC, 10);
                var rCPC_ETH = Command.GetAsksAndBids(CPC_ETH, 10);
                var rETH_BTC = Command.GetAsksAndBids(ETH_BTC, 10);

                var Qty = 100;
                var Fee = 0.9995m;
                var CPCtoBTCtoETHtoCPC = ((((rCPC_BTC.HighestBid.price * Qty * Fee) / rETH_BTC.LowestAsk.price) * Fee) / rCPC_ETH.LowestAsk.price) * Fee;
                var CPCtoETHtoBTCtoCPC = (((rCPC_ETH.HighestBid.price * Qty * Fee) * rETH_BTC.HighestBid.price * Fee) / rCPC_BTC.LowestAsk.price) * Fee;

                Console.WriteLine("CPC -> BTC -> ETH -> CPC - " + CPCtoBTCtoETHtoCPC);
                Console.WriteLine("CPC -> ETH -> BTC -> CPC - " + CPCtoETHtoBTCtoCPC);
                if(CPCtoETHtoBTCtoCPC > 100)
                {
                    revenue += CPCtoETHtoBTCtoCPC - 100;
                }
                if(CPCtoBTCtoETHtoCPC > 100)
                {
                    revenue += CPCtoBTCtoETHtoCPC - 100;
                }
                Console.WriteLine(revenue + " CPC");
                }catch(Exception e)
                {

                }
            }
        }
    }
}
