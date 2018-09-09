using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibox.Entity
{
    public class Depth
    {
        public result result { get; set; }
        public string cmd { get; set; }


        public amount HighestAsk => result.asks.OrderByDescending(x => x.price).FirstOrDefault();
        public amount LowestAsk => result.asks.OrderBy(x => x.price).FirstOrDefault();
        public amount LowestBid => result.bids.OrderBy(x => x.price).FirstOrDefault();
        public amount HighestBid => result.bids.OrderByDescending(x => x.price).FirstOrDefault();
    }

    public class result
    {
        public string pair { get; set; }
        public string update_time { get; set; }
        public ICollection<amount> bids { get; set; }
        public ICollection<amount> asks { get; set; } 
    }

    public class amount
    {
        public decimal price { get; set; }
        public decimal volume { get; set; }
    }
}
