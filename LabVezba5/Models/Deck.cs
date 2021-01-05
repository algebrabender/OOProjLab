using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LabVezba5.Models
{
    public enum Type 
    {
        STANDARD = 0,
        FRENCH
    }

    public class Deck : IModel
    {
        #region Attributes

        private List<Card> deck;
        private Type deckType;

        #endregion

        #region Constructors

        public Deck()
        {
            this.deck = new List<Card>();
        }

        public Deck(int type)
            :this()
        {
            this.deckType = (Type)type;
        }

        #endregion

        #region Methodes

        public void AddCards(int rangeFrom, int rangeTo)
        {
            Card card;

            for (int i = rangeFrom; i < rangeTo; i++)
            {
                card = new Card(Suits.CLUBS, i.ToString());
                deck.Add(card);
                card = new Card(Suits.DIAMONDS, i.ToString());
                deck.Add(card);
                card = new Card(Suits.HEARTS, i.ToString());
                deck.Add(card);
                card = new Card(Suits.SPADES, i.ToString());
                deck.Add(card);
            }

            if(this.deckType == Type.FRENCH)
            {
                card = new Card(Suits.CLUBS, "1");
                deck.Add(card);
                card = new Card(Suits.DIAMONDS, "1");
                deck.Add(card);
                card = new Card(Suits.HEARTS, "1");
                deck.Add(card);
                card = new Card(Suits.SPADES, "1");
                deck.Add(card);
            }
        }

        public void FillDeck(Type type)
        {
            if (type == 0)
                AddCards(1, 14);
            else
                AddCards(7, 14);
        }

        public void ShuffleDeck(List<Card> currentDeck)
        {
            Random rand = new Random();

            int i = currentDeck.Count;
            while (i > 1)
            {
                i--;
                int j = rand.Next(0, i + 1);
                Card temp = currentDeck[j];
                currentDeck[j] = currentDeck[i];
                currentDeck[i] = temp;
            }
        }
        
        public void NewDeck()
        {
            FillDeck(this.deckType);

            ShuffleDeck(this.deck);
        }

        public List<Card> DrawCards(int numOfCards)
        {
            List<Card> drawnCards = new List<Card>();

            if (this.deck.Count <= numOfCards)
                return null;

            for (int i = 0; i < numOfCards; i++)
            {
                int index = deck.Count - 1;
                drawnCards.Add(deck[index]);
                deck.RemoveAt(index);
            }

            return drawnCards; 
        }

        public List<Image> GetImages(List<Card> currentDeck)
        {
            List<Image> list = new List<Image>();

            foreach (Card c in currentDeck)
                list.Add(c.Img);

            list.Add(currentDeck[0].CoverImg);

            return list;
        }

        public List<Card> GetDeck()
        {
            return this.deck;
        }

        #endregion
    }
}
