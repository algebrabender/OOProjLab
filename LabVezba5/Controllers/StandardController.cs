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

        public StandardController(IModel deck, IView view, int startingPoints)
        {
            this.deck = deck;
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

            this.view.SetPoints(currentPoints);
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

        public void ReplaceToggle(int numOfCards)
        {
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

        private void CalculatePoints()
        {
            //tabela
            this.currentPoints += this.view.GetBetAmount() * 100;
        }
    }
}
