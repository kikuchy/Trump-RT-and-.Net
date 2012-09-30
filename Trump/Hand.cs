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

        public void Add(Card card)
        {
            this._cardList.Add(card);
            this._cardTable[Hand.GetTablePosition(card.Suit, card.Rank)]++;
        }

        public bool HasCardOf(Suit suit, Rank rank)
        {
            return (this._cardTable[Hand.GetTablePosition(suit, rank)] > 0);
        }

        private static int GetTablePosition(Suit suit, Rank rank)
        {
            int ret = ((int)suit - 1) * (int)Rank.King + (int)rank;
            return (ret > -1) ? ret : 0;
        }
    }
}
