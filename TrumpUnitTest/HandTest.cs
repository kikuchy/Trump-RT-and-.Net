using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trump;

namespace TrumpUnitTest
{
    [TestClass]
    public class HandTest
    {
        [TestMethod]
        public void InitializeTest()
        {
            Card[] cards = {new Card(){ Suit=Suit.Heart, Rank=Rank.Ace},
                               new Card(){ Suit=Suit.Spade, Rank=Rank.Ace},
                               new Card(){ Suit=Suit.Club, Rank=Rank.Ace},
                               new Card(){ Suit=Suit.Diamond, Rank=Rank.Ace},
                               Card.Joker};
            Hand a = new Hand(cards);
            Hand b = new Hand();
            Assert.AreEqual(a.Count, cards.Length);
            Assert.AreEqual(b.Count, 0);
        }

        [TestMethod]
        public void EnumarableTest()
        {
            Card[] cards = {new Card(){ Suit=Suit.Heart, Rank=Rank.Ace},
                               new Card(){ Suit=Suit.Spade, Rank=Rank.Ace},
                               new Card(){ Suit=Suit.Club, Rank=Rank.Ace},
                               new Card(){ Suit=Suit.Diamond, Rank=Rank.Ace},
                               Card.Joker};
            Hand a = new Hand(cards);
            int idx = 0;
            foreach (Card c in a)
            {
                Assert.AreEqual(c, cards[idx]);
                idx++;
            }
        }

        [TestMethod]
        public void AddTest()
        {
            Hand a = new Hand();
            Card c = Card.Joker;
            a.Add(c);
            Assert.AreEqual(a[0], c);
        }

        [TestMethod]
        public void RemoveAtTest()
        {
            Card[] cards = {new Card(){ Suit=Suit.Heart, Rank=Rank.Ace},
                               new Card(){ Suit=Suit.Spade, Rank=Rank.Ace},
                               new Card(){ Suit=Suit.Club, Rank=Rank.Ace},
                               new Card(){ Suit=Suit.Diamond, Rank=Rank.Ace},
                               Card.Joker};
            Hand a = new Hand(cards);
            a.RemoveAt(2);
            Assert.AreEqual(a.Count, cards.Length - 1);
            Assert.AreNotEqual(a[2], cards[2]);
        }

        [TestMethod]
        public void HasCardOfTest()
        {
            Card[] cards = {new Card(){ Suit=Suit.Heart, Rank=Rank.Ace},
                               new Card(){ Suit=Suit.Spade, Rank=Rank.Ace},
                               new Card(){ Suit=Suit.Club, Rank=Rank.Ace},
                               new Card(){ Suit=Suit.Diamond, Rank=Rank.Ace},
                               Card.Joker};
            Hand a = new Hand(cards);
            Assert.IsTrue(a.HasCardOf(cards[0]));
            a.RemoveAt(0);
            Assert.IsFalse(a.HasCardOf(cards[0]));
        }

        [TestMethod]
        public void TakeCardOfTest()
        {
            Card[] cards = {new Card(){ Suit=Suit.Heart, Rank=Rank.Ace},
                               new Card(){ Suit=Suit.Spade, Rank=Rank.Ace},
                               new Card(){ Suit=Suit.Club, Rank=Rank.Ace},
                               new Card(){ Suit=Suit.Diamond, Rank=Rank.Ace},
                               Card.Joker};
            Hand a = new Hand(cards);
            Card c = a.TakeCardOf(Suit.Heart, Rank.Ace);
            Assert.IsTrue(c == cards[0]);
            Assert.AreEqual(a.Count, cards.Length - 1);
            Assert.IsFalse(a.HasCardOf(Suit.Heart, Rank.Ace));
            Assert.IsNull(a.TakeCardOf(Suit.Heart, Rank.Ace));
        }
    }
}
