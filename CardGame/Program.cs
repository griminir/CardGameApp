using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deck = new PokerDeck();

            var hand = deck.DealCards();

            foreach (var card in hand)
            {
                Console.WriteLine($"{card.Value} of {card.Suit}");
            }
            Console.ReadLine();
        }
    }
}
