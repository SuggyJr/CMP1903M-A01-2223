using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Card
    {
        public string Grade { get; set; }
        //Gets Grade then sets it (from Ace > King)

        public string Suit { get; set; }
        //Gets Suit then sets it (Hearts, Clubs, Dimonds, Spades)

        public Card(string grade, string suit)
        {
            Grade = grade;
            Suit = suit;
        }
        //Using the perameters Grade and Suit this creates a card in the corresponding class

    }
}
