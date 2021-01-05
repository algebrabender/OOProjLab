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
        private IModel deck;
        private IView view;
        private List<Card> currentCards;
        private int currentPoints;

        public StandardController(IModel deck, IView view, int startingPoints)
        {
            this.deck = deck;
            this.view = view;
            this.view.AddListener(this);

            this.currentCards = new List<Card>();
            this.currentPoints = startingPoints;

            Start();
        }

        public void Start()
        {
            this.deck.NewDeck();
            this.view.SetPoints(currentPoints);
        }

        public void GameOver()
        {
            
        }

        public bool Draw()
        {
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
        }

        public int CalculatePoints()
        {
            return 0;
        }
    }
}
