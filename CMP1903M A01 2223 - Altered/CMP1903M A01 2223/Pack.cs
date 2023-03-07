using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public class Deck
        {
            public List<Card> deck { get; set; }
            //This function uses Grade and Suit to create a list

            public Deck()
            {
                deck = new List<Card>();
                string[] grades = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", };
                //Names for the grades
                string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
                //Names for the Suits

                foreach (string suit in suits)
                {
                    foreach (string grade in grades)
                    {
                        deck.Add(new Card(grade, suit));
                    }
                }
                //Initialises the card deck
            }
        }

        public static bool shuffleCardPack()
        {
            List<Card> sCards = new List<Card>();
            System.Console.WriteLine("There are three shuffle types for you to pick from, FisherYates (a), Riffle (b), and No Shuffle (c) please enter the    letter of your choice");
            //The system asks the user for their input
            string userInput;
            userInput = Console.ReadLine();
            //Reads "userInput" to chose a shuffle method

            if(userInput == "a")
            {
                FyShuffle(sCards);
                deal(sCards);
            }
            //FisherYates shuffle pick
            if (userInput == "b")
            {
                RfShuffle(sCards);
                deal(sCards);
            }
            //Riffle shuffle pick
            if (userInput == "b")
            {
                System.Console.WriteLine("Seriously?");
                deal(sCards);
            }
            //No shuffle, just picks a card
            return true;
        }

        public static List<Card> FyShuffle(List<Card> sCards)
        {
            Random rnd = new Random();
            int n = sCards.Count;
            while (n > 1)
            {
                n--;
                int m = rnd.Next(n + 1);
                Card value = sCards[m];
                sCards[m] = sCards[n];
                sCards[n] = value;
            }
            return sCards;
        }
        //FisherYates shuffle

        public static void RfShuffle(List<Card> sCards)
        {
            List<Card> shuffled = new List<Card>();
            Random random = new Random();
            int half = sCards.Count / 2;
            int index = 0;

            for (int i = 0; i < half; i++)
            {
                shuffled.Add(sCards[index]);
                index += 2;
            }

            index = 1;

            for (int i = 0; i < half; i++)
            {
                shuffled.Add(sCards[index]);
                index += 2;
            }
            
        }
        //Riffle shuffle

        public static Card deal(List<Card> sCards)
        {
            if(sCards.Count > 0)
            {
                System.Console.WriteLine("Here is your card!");
                Card card = sCards[0];
                sCards.RemoveAt(0);
                System.Console.WriteLine(sCards);
                return card;
            }
            return null;
        }
        //Deals card with some lines as an inteaction with the player from the computer
    }
}