using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabVezba5.Models;
using LabVezba5.View;

namespace LabVezba5.Controllers
{
    class TexasController : IController
    {
        private IModel deck;
        private IView view;

        public TexasController(IModel deck, IView view)
        {
            this.deck = deck;
            this.view = view;
            this.view.AddListener(this);
        }

        public void Start()
        {

        }

        public void GameOver()
        {

        }

        public void NewGame()
        {

        }

        public void Draw()
        {

        }
    }
}
