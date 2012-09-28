using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trump
{
    public class CardDeck
    {
        private List<Card> _cards;

        public CardDeck()
        {
            this._cards = new List<Card>();
            _Make52Deck();
            _Shuffle();
        }

        private void _Shuffle()
        {
            // TODO: デッキをシャッフルする。
            throw new NotImplementedException();
        }

        /// <summary>
        /// 標準的な、ジョーカーを除く52枚のカードからなるデッキを構築します
        /// </summary>
        private void _Make52Deck()
        {
            this._cards.Clear();
            this._cards.Add(new Card() { Suit = Suit.Heart, Rank = Rank.Ace });
            this._cards.Add(new Card() { Suit = Suit.Heart, Rank = Rank.Two });
            this._cards.Add(new Card() { Suit = Suit.Heart, Rank = Rank.Three });
            this._cards.Add(new Card() { Suit = Suit.Heart, Rank = Rank.Four });
            this._cards.Add(new Card() { Suit = Suit.Heart, Rank = Rank.Five });
            this._cards.Add(new Card() { Suit = Suit.Heart, Rank = Rank.Six });
            this._cards.Add(new Card() { Suit = Suit.Heart, Rank = Rank.Seven });
            this._cards.Add(new Card() { Suit = Suit.Heart, Rank = Rank.Eight });
            this._cards.Add(new Card() { Suit = Suit.Heart, Rank = Rank.Nine });
            this._cards.Add(new Card() { Suit = Suit.Heart, Rank = Rank.Ten });
            this._cards.Add(new Card() { Suit = Suit.Heart, Rank = Rank.Jack });
            this._cards.Add(new Card() { Suit = Suit.Heart, Rank = Rank.Queen });
            this._cards.Add(new Card() { Suit = Suit.Heart, Rank = Rank.King });

            this._cards.Add(new Card() { Suit = Suit.Club, Rank = Rank.Ace });
            this._cards.Add(new Card() { Suit = Suit.Club, Rank = Rank.Two });
            this._cards.Add(new Card() { Suit = Suit.Club, Rank = Rank.Three });
            this._cards.Add(new Card() { Suit = Suit.Club, Rank = Rank.Four });
            this._cards.Add(new Card() { Suit = Suit.Club, Rank = Rank.Five });
            this._cards.Add(new Card() { Suit = Suit.Club, Rank = Rank.Six });
            this._cards.Add(new Card() { Suit = Suit.Club, Rank = Rank.Seven });
            this._cards.Add(new Card() { Suit = Suit.Club, Rank = Rank.Eight });
            this._cards.Add(new Card() { Suit = Suit.Club, Rank = Rank.Nine });
            this._cards.Add(new Card() { Suit = Suit.Club, Rank = Rank.Ten });
            this._cards.Add(new Card() { Suit = Suit.Club, Rank = Rank.Jack });
            this._cards.Add(new Card() { Suit = Suit.Club, Rank = Rank.Queen });
            this._cards.Add(new Card() { Suit = Suit.Club, Rank = Rank.King });

            this._cards.Add(new Card() { Suit = Suit.Spade, Rank = Rank.Ace });
            this._cards.Add(new Card() { Suit = Suit.Spade, Rank = Rank.Two });
            this._cards.Add(new Card() { Suit = Suit.Spade, Rank = Rank.Three });
            this._cards.Add(new Card() { Suit = Suit.Spade, Rank = Rank.Four });
            this._cards.Add(new Card() { Suit = Suit.Spade, Rank = Rank.Five });
            this._cards.Add(new Card() { Suit = Suit.Spade, Rank = Rank.Six });
            this._cards.Add(new Card() { Suit = Suit.Spade, Rank = Rank.Seven });
            this._cards.Add(new Card() { Suit = Suit.Spade, Rank = Rank.Eight });
            this._cards.Add(new Card() { Suit = Suit.Spade, Rank = Rank.Nine });
            this._cards.Add(new Card() { Suit = Suit.Spade, Rank = Rank.Ten });
            this._cards.Add(new Card() { Suit = Suit.Spade, Rank = Rank.Jack });
            this._cards.Add(new Card() { Suit = Suit.Spade, Rank = Rank.Queen });
            this._cards.Add(new Card() { Suit = Suit.Spade, Rank = Rank.King });

            this._cards.Add(new Card() { Suit = Suit.Diamond, Rank = Rank.Ace });
            this._cards.Add(new Card() { Suit = Suit.Diamond, Rank = Rank.Two });
            this._cards.Add(new Card() { Suit = Suit.Diamond, Rank = Rank.Three });
            this._cards.Add(new Card() { Suit = Suit.Diamond, Rank = Rank.Four });
            this._cards.Add(new Card() { Suit = Suit.Diamond, Rank = Rank.Five });
            this._cards.Add(new Card() { Suit = Suit.Diamond, Rank = Rank.Six });
            this._cards.Add(new Card() { Suit = Suit.Diamond, Rank = Rank.Seven });
            this._cards.Add(new Card() { Suit = Suit.Diamond, Rank = Rank.Eight });
            this._cards.Add(new Card() { Suit = Suit.Diamond, Rank = Rank.Nine });
            this._cards.Add(new Card() { Suit = Suit.Diamond, Rank = Rank.Ten });
            this._cards.Add(new Card() { Suit = Suit.Diamond, Rank = Rank.Jack });
            this._cards.Add(new Card() { Suit = Suit.Diamond, Rank = Rank.Queen });
            this._cards.Add(new Card() { Suit = Suit.Diamond, Rank = Rank.King });
        }

        /// <summary>
        /// ジョーカーを1枚だけ含む、一般的なデッキを構築します
        /// </summary>
        private void _Make53Deck()
        {
            this._Make52Deck();
            this._cards.Add(new Card() { Suit = Suit.Joker, Rank = Rank.Joker });
        }

        /// <summary>
        /// ジョーカー2枚含む、一般的なデッキを構築します
        /// </summary>
        private void _Make54Deck()
        {
            this._Make53Deck();
            this._cards.Add(new Card() { Suit = Suit.Joker, Rank = Rank.Joker });
        }
    }
}
