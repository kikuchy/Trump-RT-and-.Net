using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trump;

namespace TrumpUnitTest
{
    [TestClass]
    public class CardDeckTest
    {
        [TestMethod]
        public void InitializeTest()
        {
            CardDeck a = new CardDeck();
            CardDeck b = new CardDeck(DeckInitType.OneJoker);
            CardDeck c = new CardDeck(DeckInitType.TwoJokers);
            CardDeck d = new CardDeck(DeckInitType.StanderdAndNonShuffle);
            Card[] one = new Card[1];
            one[0] = new Card() { Suit = Suit.Spade, Rank = Rank.King };
            CardDeck e = new CardDeck(one);
            Assert.AreEqual(a.Count, 52);
            Assert.AreNotEqual(a.Count, 53);
            Assert.AreEqual(b.Count, 53);
            Assert.AreEqual(c.Count, 54);
            Assert.AreEqual(d.Count, 52);
            Assert.AreEqual(e.Count, 1);
        }

        /// <summary>
        /// このテストは乱数を使っているため、場合によっては失敗します。もう一度実行すると通ったりする。
        /// </summary>
        [TestMethod]
        public void ShuffleTest()
        {
            CardDeck a = new CardDeck(DeckInitType.StanderdAndNonShuffle);
            CardDeck b = new CardDeck(DeckInitType.StanderdAndNonShuffle);
            Assert.AreEqual(a.TakeTopCard(), b.TakeTopCard());
            a.Shuffle();
            Assert.AreNotEqual(a.TakeTopCard(), b.TakeTopCard());
        }

        [TestMethod]
        public void TakeTopTest()
        {
            Card[] three = new Card[3];
            three[0] = new Card() { Suit = Suit.Heart, Rank = Rank.Ace };
            three[1] = new Card() { Suit = Suit.Heart, Rank = Rank.Two };
            three[2] = new Card() { Suit = Suit.Heart, Rank = Rank.Three };
            CardDeck a = new CardDeck(three);
            Assert.AreEqual(a.Count, 3);
            Assert.AreEqual(a.TakeTopCard(), three[0]);
            Assert.AreEqual(a.Count, 2);
            Assert.AreEqual(a.TakeTopCard(), three[1]);
            Assert.AreEqual(a.Count, 1);
            Assert.AreEqual(a.TakeTopCard(), three[2]);
            Assert.AreEqual(a.Count, 0);
            Assert.AreEqual(a.TakeTopCard(), null);
            Assert.AreEqual(a.Count, 0);
        }

        [TestMethod]
        public void IsEmptyTest()
        {
            Card[] one = new Card[1];
            one[0] = new Card() { Suit = Suit.Spade, Rank = Rank.King };
            CardDeck a = new CardDeck(one);
            Assert.IsFalse(a.IsEmpty);
            a.TakeTopCard();
            Assert.IsTrue(a.IsEmpty);
        }
    }
}
