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
    class TexasController : IController
    {
        #region Attributes

        private IModel deck;
        private IView view;
        private List<Card> currentCards;
        private int currentPoints;
        private int count;

        #endregion

        #region Constructor

        public TexasController(IView view, int startingPoints)
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
            CalculatePoints();

            if (count == 0)
                this.currentPoints *= 5;
            else if (count == 1)
                this.currentPoints *= 2;
            else if (count == 2)
                this.currentPoints -= this.view.GetBetAmount();
            else
                this.currentPoints -= this.view.GetBetAmount() * 2;
        }

        public bool Draw()
        {
            this.count = 0;

            this.currentCards = this.deck.DrawCards(5);

            if (currentCards == null)
                return false;

            this.currentPoints -= this.view.GetBetAmount();
            this.view.SetPoints(currentPoints);
            SetPictures();

            return true;
        }

        public void SetPictures()
        {
            List<PictureBox> list = this.view.GetPictureBoxes();
            List<Image> images = this.deck.GetImages(currentCards);

            for (int i = 0; i < 2; i++)
                list[i].Image = images[i];

            for (int i = 2; i < 5; i++)
                list[i].Image = images[5];
        }

        public void ReplaceToggle(int numOfCards)
        {
            count++;
            if (count > 3)
                return;

            List<PictureBox> list = this.view.GetPictureBoxes();
            List<Image> images = this.deck.GetImages(currentCards);

            if (list[count+1].Image == images[5])
            {
                list[count + 1].Image = images[count + 1];
            }
        }

        public int GetPoints()
        {
            return this.currentPoints;
        }

        #endregion

        private void CalculatePoints()
        {
            //tabela
            this.currentPoints = this.view.GetBetAmount() * 100;
        }
    }
}
