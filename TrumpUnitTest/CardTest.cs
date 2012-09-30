using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trump;

namespace TrumpUnitTest
{
    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void ToStringTest()
        {
            Card joker = Card.Joker;
            Assert.AreEqual(joker.ToString(), "Joker");
            Card sa = new Card() { Suit = Suit.Spade, Rank = Rank.Ace };
            Assert.AreEqual(sa.ToString(), "Spade:Ace");
        }

        [TestMethod]
        public void EqualesTest()
        {
            Card a = new Card() { Suit = Suit.Spade, Rank = Rank.Ace };
            Card b = new Card() { Suit = Suit.Spade, Rank = Rank.Ace };
            Card c = new Card() { Suit = Suit.Diamond, Rank = Rank.Ace };
            Assert.IsTrue(a == b);
            Assert.IsFalse(a == c);
            Assert.IsFalse(a != b);
            Assert.IsTrue(a != c);
        }

        [TestMethod]
        public void IsJokerTest()
        {
            Card joker = Card.Joker;
            Assert.IsTrue(joker.IsJoker);
            Card a = new Card() { Suit = Suit.Heart, Rank = Rank.Queen };
            Assert.IsFalse(a.IsJoker);
        }

        [TestMethod]
        public void GetHashCodeTest()
        {
            Card a = new Card() { Suit = Suit.Heart, Rank = Rank.Two };
            Card b = new Card() { Suit = Suit.Heart, Rank = Rank.Two };

            // このメソッドで返るハッシュは、等価なインスタンスでは同じ必要があるが、等価でないインスタンスは違うハッシュを返す必要がない、とされている
            Assert.AreEqual(a.GetHashCode(), b.GetHashCode());
        }
    }
}
