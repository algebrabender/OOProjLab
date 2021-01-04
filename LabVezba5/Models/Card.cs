using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabVezba5.Models
{
    public enum Suits
    {
        CLUBS = 0,
        DIAMONDS,
        HEARTS,
        SPADES
    }

    public class Card
    {
        #region Attributes

        private Suits suit;
        private String cardNumber;
        private int cardValue;
        //pic path

        #endregion

        #region Properties

        public Suits Suit
        {
            get { return this.suit; }
        }

        public String CardNumber
        {
            get { return this.cardNumber; }
        }

        public int CardValue
        {
            get { return this.cardValue; }
        }

        #endregion

        #region Constructor

        public Card(Suits suit, String cardNumber)
        {
            this.suit = suit;

            switch (cardNumber)
            {
                case "1":
                    this.cardNumber = "A";
                    break;
                case "11":
                    this.cardNumber = "J";
                    break;
                case "12":
                    this.cardNumber = "Q";
                    break;
                case "13":
                    this.cardNumber = "K";
                    break;
                default:
                    break;
            }

            this.cardValue = Int32.Parse(cardNumber);
        }

        #endregion
    }
}
