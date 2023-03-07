using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class CardAlt
    {
        //internal string Suit;
        //internal string Rank;
        public string suit;
        public string rank;

        public CardAlt(string suit, string rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public string Suit { get; internal set; }
        public string Rank { get; internal set; }

        //Card Altered
        public class CardPack
        {
            public string Suit { get; set; }
            public string Rank { get; set; }

            public CardPack(string suit, string rank)
            {
                Suit = suit;
                Rank = rank;
            }
        }
    }
}
