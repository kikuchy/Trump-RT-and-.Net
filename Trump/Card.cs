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
    }
}
