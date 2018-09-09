using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibox.Entity
{
    public class Pair
    {
        public int Id { get; set; }
        public int FirstId { get; set; }
        public Token First { get; set; }
        public int SecondId { get; set; }
        public Token Second { get; set; }

        public ICollection<Price> Prices { get; set; }

        public Pair(int id, Token first, Token second)
        {
            Id = id;
            FirstId = first.Id;
            First = first;
            SecondId = second.Id;
            Second = second;
        }
    }
}
