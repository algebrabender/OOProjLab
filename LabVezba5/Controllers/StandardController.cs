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
        #region Attributes

        private IModel deck;
        private IView view;
        private List<Card> currentCards;
        private int currentPoints;
        private bool pointsCalculated;

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

        public void GameOver()
        {
            if (!this.pointsCalculated)
                CalculatePoints();
        }

        public bool Draw()
        {
            this.currentCards = this.deck.DrawCards(5);

            if (currentCards == null)
                return false;

            this.currentPoints -= this.view.GetBetAmount();

            if (currentPoints == 0)
                return false;

            SetPictures();

            CalculatePoints();
            this.pointsCalculated = true;
            this.view.SetPoints(currentPoints);

            return true;
        }

        public void SetPictures()
        {
            List<PictureBox> list = this.view.GetPictureBoxes();
            List<Image> images = this.deck.GetImages(this.currentCards);

            for (int i = 0; i < 5; i++)
                list[i].Image = images[i]; 
        }

        public void ReplaceToggle(int numOfCards)
        {
            if (numOfCards == 0)
            {
                CalculatePoints();
                return;
            }

            Random rand = new Random();

            List<Card> currentDeck = this.deck.GetDeck();
            
            this.deck.ShuffleDeck(currentDeck);

            Card forSwapping;

            for (int i = 0; i < numOfCards; i++)
            {
                forSwapping = currentDeck[rand.Next(0, currentDeck.Count - 1)];
                currentDeck.Remove(forSwapping);
                int index = rand.Next(0, 5);
                currentDeck.Add(currentCards[index]);
                this.currentCards[index] = forSwapping;
            }

            SetPictures();

            CalculatePoints();
            //proveriti da li funkcionise kako treba/da li treba neki message
            this.pointsCalculated = true;
        }

        public int GetPoints()
        {
            return this.currentPoints;
        }

        #endregion

        #region Methodes

        private void CalculatePoints()
        {
            Card temp = new Card();

            if (StraightFlush())
            {
                this.currentPoints += this.view.GetBetAmount() * 100;
                //return;
            }
            else if (FourOfAKind())
            {
                this.currentPoints += this.view.GetBetAmount() * 60;
                //return;
            }
            else if (BigBobTail())
            {
                this.currentPoints += this.view.GetBetAmount() * 40;
                //return;
            }
            else if(FullHouse())
            {
                this.currentPoints += this.view.GetBetAmount() * 24;
                //return;
            }
            else if (Flush())
            {
                this.currentPoints += this.view.GetBetAmount() * 16;
                //return;
            }
            else if(Straight())
            {
                this.currentPoints += this.view.GetBetAmount() * 12;
                //return;
            }
            else if(Blaze())
            {
                this.currentPoints += this.view.GetBetAmount() * 9;
                //return;
            }
            else if (ThreeOFAKind(out temp))
            {
                this.currentPoints += this.view.GetBetAmount() * 6;
                //return;
            }
            else if (TwoPair())
            {
                this.currentPoints += this.view.GetBetAmount() * 4;
                //return;
            }
            else if (OnePair(out temp))
            {
                this.currentPoints += this.view.GetBetAmount() * 2;
                //return;
            }
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
                            return true;
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
            //samo base slucajevi treba dodati za A

            this.currentCards.Sort((x, y) => y.CardValue.CompareTo(x.CardValue));

            if (this.currentCards[0].CardValue == this.currentCards[1].CardValue +1) //1-2
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
            //not tested
             
            foreach(Card c in this.currentCards)
            {
                this.currentCards.Remove(c);
                if (Straight())
                {
                    if (Flush())
                    {
                        this.currentCards.Add(c);
                        return true;
                    }
                }
            }

            return false;
        }

        private bool FourOfAKind()
        {
            //potencijalno optimizovati

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
            if (Straight())
                return Flush();

            return false;
        }

        #endregion
    }
}
