using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        // Pack Altered
        public class Pack
        {
            private List<Card> cards;

            public Pack()
            {
                cards = new List<Card>();
                string[] suits = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };
                string[] ranks = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

                foreach (string suit in suits)
                {
                    foreach (string rank in ranks)
                    {
                        cards.Add(new Card(suit, rank));
                    }
                }
            }

            public bool shuffleCardPack(int typeOfShuffle)
            {
                switch (typeOfShuffle)
                {
                    case 1:
                        FisherYatesShuffle();
                        break;
                    case 2:
                        RiffleShuffle();
                    break;
                    case 3:
                        // No shuffle
                    break;
                    default:
                        return false;
                }

                return true;
            }

            private void FisherYatesShuffle()
            {
                Random random = new Random();
                for (int i = cards.Count - 1; i > 0; i--)
                {
                    int j = random.Next(i + 1);
                    Card temp = cards[i];
                   cards[i] = cards[j];
                    cards[j] = temp;
                }
            }

            private void RiffleShuffle()
            {
                List<Card> shuffled = new List<Card>();
                Random random = new Random();
                int half = cards.Count / 2;
                int index = 0;

                for (int i = 0; i < half; i++)
                {
                    shuffled.Add(cards[index]);
                    index += 2;
                }

                index = 1;

                for (int i = 0; i < half; i++)
                {
                    shuffled.Add(cards[index]);
                    index += 2;
                }

                cards = shuffled;
            }

            public Card dealCard()
            {
                if (cards.Count == 0)
                {
                    return null;
                }

                Card card = cards[0];
                cards.RemoveAt(0);
                return card;
            }

            public List<Card> dealCard(int amount)
            {
                if (amount > cards.Count)
                {
                    return null;
                }

                List<Card> dealtCards = new List<Card>();
                for (int i = 0; i < amount; i++)
                {
                    dealtCards.Add(dealCard());
                }

                return dealtCards;
            }
        }

    }
}
