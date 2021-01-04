using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabVezba5.Models
{
    public enum Type 
    {
        STANDARD = 0,
        FRENCH
    }

    public class Deck : IModel
    {
        private List<Card> deck;
        private Type deckType;

        public List<Card> GetDeck
        {
            get { return this.deck; }
        }

        public Type DeckType
        {
            get { return this.deckType; }
            set { this.deckType = value; }
        }

        public Deck()
        {
            this.deck = new List<Card>();
        }

        public Deck(int type)
            :base()
        {
            this.deckType = (Type)type;
        }

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
            //todo
        }
        
        public void NewDeck(Type type)
        {
            this.deck.Clear();

            FillDeck(type);

            ShuffleDeck(this.deck);
        }

        public List<Card> DrawCards(int numbOfCards)
        {
            List<Card> drawnCards = new List<Card>();

            for (int i = 0; i < numbOfCards; i++)
            {
                int index = deck.Count - 1;
                drawnCards.Add(deck[index]);
                deck.RemoveAt(index);
            }

            return drawnCards; 
        }
    }
}
