using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class BlackJackDeck :Deck
    {
        public BlackJackDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }

        public override List<PlayingCard> DealCards()
        {
            var output = new List<PlayingCard>();

            for (int i = 0; i < 2; i++)
            {
                output.Add(DrawOneCard());
            }
            return output;
        }

        public PlayingCard RequestCard()
        {
            return DrawOneCard();
        }
    }
}
