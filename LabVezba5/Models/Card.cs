﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

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
        private Image img;
        private Image coverImg;

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

        public Image Img
        {
            get { return this.img; }
        }

        public Image CoverImg
        {
            get { return this.coverImg; }
        }

        #endregion

        #region Constructors

        public Card()
        {

        }

        public Card(Suits suit, String cardNumber)
        {
            this.suit = suit;
            String imgName = "";

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
                    this.cardNumber = cardNumber;
                    break;
            }

            switch (this.suit)
            {
                case Suits.CLUBS:
                    imgName += this.cardNumber + "C";
                    break;
                case Suits.DIAMONDS:
                    imgName += this.cardNumber + "D";
                    break;
                case Suits.HEARTS:
                    imgName += this.cardNumber + "H";
                    break;
                case Suits.SPADES:
                    imgName += this.cardNumber + "S";
                    break;
            }

            this.cardValue = Int32.Parse(cardNumber);

            SetImage(imgName);
        }

        #endregion

        private void SetImage(String imgName)
        {
            //uzima sve fajlove iz foldera sa kartama
            String[] cardImgs = Directory.GetFiles("../../Cards/");

            //trazi fajl koji odgovara imenu karte 
            //sve karte su u formatu VrednostOznaka
            foreach (String cardImg in cardImgs)
            {
                String woExtension = Path.GetFileNameWithoutExtension(cardImg);

                if (woExtension == imgName)
                    this.img = Image.FromFile(cardImg);

                //postavljanje backcover
                if (woExtension == "yellow_back")
                    this.coverImg = Image.FromFile(cardImg);
            }
        }        
    }
}
