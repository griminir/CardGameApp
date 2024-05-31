using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public abstract class Deck
    {
        protected List<PlayingCard> fullDeck = new List<PlayingCard>();
        protected List<PlayingCard> DrawPile = new List<PlayingCard>();
        protected List<PlayingCard> discardPile = new List<PlayingCard>();
        protected void CreateDeck()
        {
            fullDeck.Clear();

            for (int suit = 0; suit < 4; suit++)
            {
                for (int val = 0; val < 13; val++)
                {
                    fullDeck.Add(new PlayingCard {Suit = (CardSuit)suit, Value = (CardValue)val});
                }
            }
        }

        public virtual void ShuffleDeck()
        {
            var rand = new Random();
            DrawPile = fullDeck.OrderBy(x => rand.Next()).ToList();
        }

        public abstract List<PlayingCard> DealCards();

        protected virtual PlayingCard DrawOneCard()
        {
            var output = DrawPile.Take(1).First();
            DrawPile.Remove(output);
            return output;
        }
    }
}
