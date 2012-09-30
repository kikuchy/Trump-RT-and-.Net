using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trump
{
    public class Hand
    {
        private int[] _cardTable = new int[53];
        private List<Card> _cardList = new List<Card>();

        public void AddCard(Card card)
        {
            this._cardList.Add(card);
            if (card.IsJoker)
            {
                this._cardTable[0]++;
            }
            else
            {
                this._cardTable[((int)card.Suit - 1) * (int)Rank.King + (int)card.Rank]++;
            }
        }

        public bool HasCardOf(Suit suit, Rank rank)
        {
            return (this._cardTable[((int)suit - 1) * (int)Rank.King + (int)rank] > 0);
        }
    }
}
