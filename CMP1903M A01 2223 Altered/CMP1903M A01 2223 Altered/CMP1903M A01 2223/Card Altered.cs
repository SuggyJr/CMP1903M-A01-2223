using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Card Altered
        public class Card
        {
            public string Suit { get; set; }
            public string Rank { get; set; }

            public Card(string suit, string rank)
            {
                Suit = suit;
                Rank = rank;
            }
        }
    }
}
