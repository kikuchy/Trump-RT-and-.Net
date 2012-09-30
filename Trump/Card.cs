using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trump
{
    /// <summary>
    /// トランプのカード1枚を表します。カードはスート(マーク)とランク(数字)からなっています。
    /// </summary>
    public class Card
    {
        /// <summary>
        /// ジョーカーを取得します。
        /// </summary>
        public static Card Joker
        {
            get
            {
                return new Card() { Suit = Suit.Joker, Rank = Rank.Joker };
            }
        }

        /// <summary>
        /// このカードのスート(マーク)を表します。
        /// </summary>
        public Suit Suit;

        /// <summary>
        /// このカードのランク(数字)を表します。
        /// </summary>
        public Rank Rank;

        /// <summary>
        /// このカードがジョーカーであるかどうかを取得します。
        /// </summary>
        public bool IsJoker
        {
            get
            {
                return (this.Suit == Suit.Joker) || (this.Rank == Rank.Joker);
            }
        }

        /// <summary>
        /// 現在のカードを表す文字列を返します。
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string ret;
            if (this.IsJoker)
            {
                ret = "Joker";
            }
            else
            {
                ret = string.Format("{0}:{1}", this.Suit, this.Rank);
            }
            return ret;
        }

        /// <summary>
        /// 指定した System.Object が、現在の System.Object と等しいかどうかを判断します。
        /// </summary>
        /// <param name="obj">現在のオブジェクトと比較するオブジェクト。</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Card card = obj as Card;
            if ((Object)card == null)
                return false;
            return (this.Suit == card.Suit) && (this.Rank == card.Rank);
        }

        /// <summary>
        /// 特定の型のハッシュ関数として機能します。
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (int)this.Suit ^ (int)this.Rank;
        }


        public static bool operator ==(Card a, Card b)
        {
            if (System.Object.ReferenceEquals(a, b))
                return true;
            if (((object)a == null) || ((object)b == null))
                return false;
            return a.Rank == b.Rank && a.Suit == b.Suit;
        }

        public static bool operator !=(Card a, Card b){
            return !(a == b);
            }
    }
}
