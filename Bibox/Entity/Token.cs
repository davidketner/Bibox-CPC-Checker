using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibox.Entity
{
    public class Token
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }

        public Token(int id, string symbol, string name)
        {
            Id = id;
            Symbol = symbol;
            Name = name;
        }


    }
}
