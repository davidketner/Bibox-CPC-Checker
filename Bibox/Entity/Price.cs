using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibox.Entity
{
    public enum PriceType
    {
        Bid,
        Ask
    }

    public class Price
    {
        public int Id { get; set; }
        public int PairId { get; set; }
        public Pair Pair { get; set; }
        public PriceType PriceType { get; set; }
        public decimal Amount { get; set; }
        public decimal Volume { get; set; }
    }
}
