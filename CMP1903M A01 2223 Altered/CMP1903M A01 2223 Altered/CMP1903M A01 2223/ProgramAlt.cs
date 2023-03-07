using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class ProgramAlt
    {
        // Program Altered
        public class Testing
        {
            public static void Main()
            {
                // Creates the pack
                PackAlt pack = new PackAlt();

                // Shuffles using the different types of shuffle
                pack.shuffleCardPack(1);
                pack.shuffleCardPack(2);
                pack.shuffleCardPack(3);

                // Deals cards
                CardAlt card1 = pack.dealCard();
                List<CardAlt> cards = pack.dealCard(5);

                // Checks what is returned
                Console.WriteLine(card1.Suit + " " + card1.Rank);
                foreach (CardAlt card in cards)
                {
                    Console.WriteLine(card.Suit + " " + card.Rank);
                }
            }
        }
    }
}