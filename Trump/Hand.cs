using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trump
{
    /// <summary>
    /// カードを保持する、手札を表すクラスです。
    /// 単にカードを保持するだけでなく、「手札に、今あってほしいカードがあるか」「特定のカードを手札から出す」といった操作を高速に行えるように実装されています。
    /// </summary>
    public class Hand :  IEnumerable
    {
        /// <summary>
        /// どの種類のカードが何枚あるのかを記録するテーブル。
        /// [0]はジョーカー、[1]はハートのエース…という並びになっています。
        /// </summary>
        private int[] _cardNumTable = new int[53];

        private int[] _cardIdxTable = new int[53];

        /// <summary>
        /// 手札にあるカードの実態を保持しているリスト。手札にあるカードを端から見ていきたいときなどに使う。
        /// </summary>
        private List<Card> _cardList = new List<Card>();

        /// <summary>
        /// 指定したインデックスにあるカードを取得または設定します。 
        /// </summary>
        /// <param name="i">取得または設定するカードの、0 から始まるインデックス番号。</param>
        /// <returns>指定したインデックスのカード。</returns>
        public Card this[int i]
        {
            set
            {
                Card oldCard = this._cardList[i];
                this.RemoveAt(i);
                this._cardList[i] = value;
                int idx = Hand.GetTablePosition(oldCard.Suit, oldCard.Rank);
                this._cardNumTable[idx]++;
                if (this._cardIdxTable[idx] == -1)
                    this._cardIdxTable[idx] = this._cardList.Count - 1;
            }
            get
            {
                return this._cardList[i];
            }
        }

        /// <summary>
        /// 手札にあるカードの枚数を取得します。
        /// </summary>
        public int Count
        {
            get
            {
                return this._cardList.Count;
            }
        }

        /// <summary>
        /// 手札にカードが残っていないかどうかを取得します。
        /// </summary>
        public bool IsEmpty
        {
            get
            {
                return (this._cardList.Count <= 0);
            }
        }

        /// <summary>
        /// 手札を初期化します。
        /// </summary>
        public Hand()
        {
            this.InitTables();
        }

        /// <summary>
        /// 指定したカード列から手札を初期化します。
        /// </summary>
        /// <param name="cards">指定するカード列。</param>
        public Hand(IEnumerable<Card> cards)
        {
            this.InitTables();
            foreach (Card c in cards)
            {
                this.Add(c);
            }
        }

        /// <summary>
        /// 手札の末尾にカードを追加します。
        /// </summary>
        /// <param name="card">追加するカード。</param>
        public void Add(Card card)
        {
            this._cardList.Add(card);
            int idx = Hand.GetTablePosition(card.Suit, card.Rank);
            this._cardNumTable[idx]++;
            if (this._cardIdxTable[idx] == -1)
                this._cardIdxTable[idx] = this._cardList.Count - 1;
        }

        /// <summary>
        /// 指定したインデックスにある要素を削除します。
        /// </summary>
        /// <param name="i">削除する要素の、0 から始まるインデックス番号。</param>
        /// /// <remarks>このメソッドは、同じ種類のカードが手札に1枚しかない場合、O(1)操作です。
        /// 2枚以上ある場合はO(n)操作になります(nはCountの値)。</remarks>
        public void RemoveAt(int i)
        {
            Card oldCard = this._cardList[i];
            this._cardList.RemoveAt(i);
            int idx = Hand.GetTablePosition(oldCard.Suit, oldCard.Rank);
            this._cardNumTable[idx]--;
            if (this.HasCardOf(oldCard))
            {
                this._cardIdxTable[idx] = this._cardList.IndexOf(oldCard);
            }
        }

        /// <summary>
        /// 指定した種類のカードが手札に存在するかどうかを判定します。
        /// </summary>
        /// <param name="suit">指定するカードのスート(マーク)</param>
        /// <param name="rank">指定するカードのランク(数字)</param>
        /// <returns></returns>
        public bool HasCardOf(Suit suit, Rank rank)
        {
            return (this._cardNumTable[Hand.GetTablePosition(suit, rank)] > 0);
        }

        /// <summary>
        /// 指定した種類のカードが手札に存在するかどうかを判定します。
        /// </summary>
        /// <param name="card">指定するカード</param>
        /// <returns></returns>
        public bool HasCardOf(Card card)
        {
            return this.HasCardOf(card.Suit, card.Rank);
        }

        /// <summary>
        /// 指定した種類のカードを手札から出します。
        /// </summary>
        /// <param name="card">指定するカード</param>
        /// <returns>指定されたカード。指定されたカードが存在しない場合、null。</returns>
        /// <remarks>このメソッドは、同じ種類のカードが手札に1枚しかない場合、O(1)操作です。
        /// 2枚以上ある場合はO(n)操作になります(nはCountの値)。</remarks>
        public Card TakeCardOf(Card card)
        {
            if (!this.HasCardOf(card))
                return null;
            int idx = Hand.GetTablePosition(card.Suit, card.Rank);
            Card ret = this._cardList[this._cardIdxTable[idx]];
            this.RemoveAt(this._cardIdxTable[idx]);
            return ret;
        }

        /// <summary>
        /// 指定した種類のカードを手札から出します。
        /// </summary>
        /// <param name="suit">指定するカードのスート(マーク)</param>
        /// <param name="rank">指定するカードのランク(数字)</param>
        /// <returns>指定されたカード。指定されたカードが存在しない場合、null。</returns>
        /// <remarks>このメソッドは、同じ種類のカードが手札に1枚しかない場合、O(1)操作です。
        /// 2枚以上ある場合はO(n)操作になります(nはCountの値)。</remarks>
        public Card TakeCardOf(Suit suit, Rank rank)
        {
            return this.TakeCardOf(new Card() { Suit = suit, Rank = rank });
        }

        /// <summary>
        /// この手札を反復処理する列挙子を返します。
        /// </summary>
        /// <returns>コレクションを反復処理するために使用できる IEnumerator 。</returns>
        public IEnumerator GetEnumerator()
        {
            return this._cardList.GetEnumerator();
        }

        /// <summary>
        /// 内部的に使用してる。テーブルを初期化します。
        /// </summary>
        private void InitTables()
        {
            for (int i = 0; i < 53; i++)
            {
                this._cardIdxTable[i] = -1;
                this._cardNumTable[i] = 0;
            }
        }

        /// <summary>
        /// カードの種類から、テーブルのインデックスを算出します。
        /// </summary>
        /// <param name="suit">指定するカードのスート(マーク)</param>
        /// <param name="rank">指定するカードのランク(数字)</param>
        /// <returns></returns>
        private static int GetTablePosition(Suit suit, Rank rank)
        {
            int ret = ((int)suit - 1) * (int)Rank.King + (int)rank;
            return (ret > -1) ? ret : 0;
        }
    }
}
