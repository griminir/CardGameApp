using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class PokerDeck : Deck
    {
        public PokerDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }

        public override List<PlayingCard> DealCards()
        {
            var output = new List<PlayingCard>();

            for (int i = 0; i < 5; i++)
            {
                output.Add(DrawOneCard());
            }
            return output;
        }

        public List<PlayingCard> RequestCards(List<PlayingCard> cardsToDiscard)
        {
            var output = new List<PlayingCard>();

            foreach (var card in cardsToDiscard)
            {
                output.Add(DrawOneCard());
                discardPile.Add(card);
            }
            return output;
        }
    }
}
