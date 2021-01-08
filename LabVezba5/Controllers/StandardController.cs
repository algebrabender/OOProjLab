using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using LabVezba5.Models;
using LabVezba5.View;

namespace LabVezba5.Controllers
{
    class StandardController : IController
    {
        //koriscenje MVC patterna kao sto je bilo naznaceno u prvoj verziji lab vezbe

        #region Attributes

        private IModel deck;
        private IView view;
        private List<Card> currentCards;
        private int currentPoints;
        private bool pointsCalculated = false;

        #endregion

        #region Constructor

        public StandardController(IView view, int startingPoints)
        {
            this.deck = new Deck();
            this.view = view;
            this.view.AddListener(this);

            this.currentCards = new List<Card>();
            this.currentPoints = startingPoints;

            Start();
        }

        #endregion

        #region Interface Implementation

        public void Start()
        {
            this.deck.NewDeck();
            this.view.SetPoints(currentPoints);
        }

        public bool Draw()
        {
            this.currentCards = this.deck.DrawCards(5);

            //nema vise karata za deljenje
            if (currentCards == null)
                return false;

            this.currentPoints -= this.view.GetBetAmount();

            //igra zavrsena
            if (currentPoints <=0)
                return false;

            SetPictures();

            this.pointsCalculated = false;

            return true;
        }

        public void SetPictures()
        {
            List<PictureBox> list = this.view.GetPictureBoxes();
            List<Image> images = this.deck.GetImages(this.currentCards);

            for (int i = 0; i < 5; i++)
                list[i].Image = images[i]; 
        }

        public void Replace(int numOfCards, List<Image> list)
        {
            if (numOfCards == 0)
            {
                if (this.pointsCalculated)
                {
                    this.view.SetWonPoints(0);
                    return;
                }
                CalculatePoints();

                //zbog sortiranja u proverama potrebno resetovati slike
                SetPictures();

                this.pointsCalculated = true;
                
                return;
            }

            Random rand = new Random();

            List<Card> currentDeck = this.deck.GetDeck();
            
            this.deck.ShuffleDeck(currentDeck);

            int []index = new int[numOfCards];
            
            Card card;

            int j = 0;

            for (int i = 0; i< this.currentCards.Count -1; i++)
            {
                foreach (Image img in list)
                {
                    if (this.currentCards[i].Img == img)
                    {
                        index[j] = i;
                        j++;
                        break;
                    }
                }
            }

            for (int i = 0; i < numOfCards; i++)
            {
                card = currentDeck[rand.Next(0, currentDeck.Count - 1)];
                currentDeck.Remove(card);
                currentDeck.Add(this.currentCards[index[i]]);
                this.currentCards[index[i]] = card;
            }

            CalculatePoints();

            //zbog sortiranja u proverama potrebno resetovati slike
            SetPictures();
            
            this.pointsCalculated = true;
        }

        public int GetPoints()
        {
            if (!this.pointsCalculated && this.currentCards != null)
            {
                CalculatePoints();

                //zbog sortiranja u proverama potrebno resetovati slike
                SetPictures();
            
                this.pointsCalculated = true;
            }

            return this.currentPoints;
        }

        #endregion

        #region Methodes

        private void CalculatePoints()
        {
            Card temp;

            if (StraightFlush())
            {
                int wonPoints = this.view.GetBetAmount() * 100;
                this.currentPoints += wonPoints;
                this.view.SetWonPoints(wonPoints);
            }
            else if (FourOfAKind())
            {
                int wonPoints = this.view.GetBetAmount() * 60;
                this.currentPoints += wonPoints;
                this.view.SetWonPoints(wonPoints);
            }
            else if (BigBobTail())
            {
                int wonPoints = this.view.GetBetAmount() * 40;
                this.currentPoints += wonPoints;
                this.view.SetWonPoints(wonPoints);
            }
            else if(FullHouse())
            {
                int wonPoints = this.view.GetBetAmount() * 24;
                this.currentPoints += wonPoints;
                this.view.SetWonPoints(wonPoints);
            }
            else if (Flush())
            {
                int wonPoints = this.view.GetBetAmount() * 16;
                this.currentPoints += wonPoints;
                this.view.SetWonPoints(wonPoints);
            }
            else if(Straight())
            {
                int wonPoints = this.view.GetBetAmount() * 12;
                this.currentPoints += wonPoints;
                this.view.SetWonPoints(wonPoints);
            }
            else if(Blaze())
            {
                int wonPoints = this.view.GetBetAmount() * 9;
                this.currentPoints += wonPoints;
                this.view.SetWonPoints(wonPoints);
            }
            else if (ThreeOFAKind(out temp))
            {
                int wonPoints = this.view.GetBetAmount() * 6;
                this.currentPoints += wonPoints;
                this.view.SetWonPoints(wonPoints);
            }
            else if (TwoPair())
            {
                int wonPoints = this.view.GetBetAmount() * 4;
                this.currentPoints += wonPoints;
                this.view.SetWonPoints(wonPoints);
            }
            else if (OnePair(out temp))
            {
                int wonPoints = this.view.GetBetAmount() * 2;
                this.currentPoints += wonPoints;
                this.view.SetWonPoints(wonPoints);
            }
            else //novi poeni nisu osvojeni
                this.view.SetWonPoints(0);

            this.view.SetPoints(currentPoints);
        }

        private bool OnePair(out Card c)
        {
            c = null;

            for (int i = 0; i < this.currentCards.Count - 1; i++)
            {
                for (int j = i + 1; j < this.currentCards.Count; j++)
                {
                    if (this.currentCards[i].CardValue == this.currentCards[j].CardValue)
                    {
                        c = this.currentCards[i];
                        return true;
                    }
                }
            }

            return false;
        }

        private bool TwoPair()
        {
            Card temp;
            
            if(OnePair(out temp))
            {
                this.currentCards.Remove(temp);

                for (int i = 0; i < this.currentCards.Count - 1; i++)
                {
                    for (int j = i + 1; j < this.currentCards.Count; j++)
                    {
                        if (this.currentCards[i].CardValue == this.currentCards[j].CardValue)
                        {
                            this.currentCards.Add(temp);
                            return true;
                        }
                    }
                }

                this.currentCards.Add(temp);
            }

            return false;
        }

        private bool ThreeOFAKind(out Card c)
        {
            c = null;

            for(int i = 0; i < this.currentCards.Count - 2; i++)
            {
                for (int j = i+1; j < this.currentCards.Count - 1; j++)
                {
                    if (this.currentCards[i].CardValue == this.currentCards[j].CardValue)
                    {
                        for (int k = j+1; k < this.currentCards.Count; k++)
                        {
                            if (this.currentCards[i].CardValue == this.currentCards[k].CardValue)
                            {
                                c = this.currentCards[i];
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        private bool Blaze()
        {
            foreach(Card c in this.currentCards)
            {
                if (c.CardNumber != "J" && c.CardNumber != "Q" && c.CardNumber != "K")
                    return false;
            }

            return true;
        }

        private bool Straight()
        {
            this.currentCards.Sort((x, y) => y.CardValue.CompareTo(x.CardValue));

            if (this.currentCards[4].CardValue == 1)
            {
                //provera za A-K-Q-J-10
                if (this.currentCards[0].CardNumber == "K")
                {
                    if (this.currentCards[0].CardValue == this.currentCards[1].CardValue + 1) //K-Q
                        if (this.currentCards[1].CardValue == this.currentCards[2].CardValue + 1) //Q-J
                            if (this.currentCards[2].CardValue == this.currentCards[3].CardValue + 1) //J-10
                                return true;
                }
            }

            if (this.currentCards[0].CardValue == this.currentCards[1].CardValue + 1) //1-2
                if (this.currentCards[1].CardValue == this.currentCards[2].CardValue + 1) //2-3
                    if (this.currentCards[2].CardValue == this.currentCards[3].CardValue + 1) //3-4
                        if (this.currentCards[3].CardValue == this.currentCards[4].CardValue + 1) //4-5
                            return true;

            return false;
        }

        private bool Flush()
        {
            Card temp = this.currentCards[0];

            for (int i = 1; i < this.currentCards.Count; i++)
            {
                if (this.currentCards[i].Suit != temp.Suit)
                    return false;
            }

            return true;
        }

        private bool FullHouse()
        {
            Card temp;

            if (ThreeOFAKind(out temp))
            {
                this.currentCards.Remove(temp);

                if (TwoPair())
                {
                    this.currentCards.Add(temp);
                    return true;
                }

                this.currentCards.Add(temp);
            }

            return false;
        }

        private bool BigBobTail()
        {
            this.currentCards.Sort((x, y) => y.CardValue.CompareTo(x.CardValue));

            if (this.currentCards[4].CardValue == 1)
            {
                //provera za A-K-Q-J
                if ((this.currentCards[0].Suit == this.currentCards[4].Suit) && this.currentCards[0].CardNumber == "K")
                {
                    //potencijalno mogu biti i iste karte za redom jer su nam potrebne 4 iste
                    if ((this.currentCards[0].Suit == this.currentCards[1].Suit) && (this.currentCards[0].CardValue == this.currentCards[1].CardValue) && (this.currentCards[0].CardValue == this.currentCards[1].CardValue + 1))//K-Q
                        if ((this.currentCards[1].Suit == this.currentCards[2].Suit) && (this.currentCards[0].CardValue == this.currentCards[1].CardValue) && (this.currentCards[1].CardValue == this.currentCards[2].CardValue + 1)) //Q-J
                            return true;
                }
            }

            //potencijalno mogu biti i iste karte za redom jer su nam potrebne 4 iste
            if ((this.currentCards[0].Suit == this.currentCards[1].Suit) && ((this.currentCards[0].CardValue == this.currentCards[1].CardValue) || (this.currentCards[0].CardValue == this.currentCards[1].CardValue + 1))) //1-2
                if ((this.currentCards[1].Suit == this.currentCards[2].Suit) && ((this.currentCards[1].CardValue == this.currentCards[2].CardValue) || (this.currentCards[1].CardValue == this.currentCards[2].CardValue + 1))) //2-3
                    if ((this.currentCards[2].Suit == this.currentCards[3].Suit) && ((this.currentCards[2].CardValue == this.currentCards[3].CardValue) || (this.currentCards[2].CardValue == this.currentCards[3].CardValue + 1))) //3-4
                        return true;

            if ((this.currentCards[1].Suit == this.currentCards[2].Suit) && ((this.currentCards[1].CardValue == this.currentCards[2].CardValue) || (this.currentCards[1].CardValue == this.currentCards[2].CardValue + 1))) //1-2
                if ((this.currentCards[2].Suit == this.currentCards[3].Suit) && ((this.currentCards[2].CardValue == this.currentCards[3].CardValue) || (this.currentCards[2].CardValue == this.currentCards[3].CardValue + 1))) //2-3
                    if ((this.currentCards[3].Suit == this.currentCards[4].Suit) && ((this.currentCards[3].CardValue == this.currentCards[4].CardValue) || (this.currentCards[3].CardValue == this.currentCards[4].CardValue + 1))) //3-4
                        return true;

            return false;
        }

        private bool FourOfAKind()
        {
            for (int i = 0; i < this.currentCards.Count - 2; i++)
            {
                for (int j = i + 1; j < this.currentCards.Count - 1; j++)
                {
                    if (this.currentCards[i].CardValue == this.currentCards[j].CardValue)
                    {
                        for (int k = j + 1; k < this.currentCards.Count; k++)
                        {
                            if (this.currentCards[i].CardValue == this.currentCards[k].CardValue)
                            {
                                for (int l = j + 1; l < this.currentCards.Count; l++)
                                {
                                    if (this.currentCards[i].CardValue == this.currentCards[l].CardValue)
                                    {
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        private bool StraightFlush()
        {
            if (Flush())
                return Straight();

            return false;
        }

        #endregion
    }
}
