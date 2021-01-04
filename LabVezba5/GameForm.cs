using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabVezba5.View;
using LabVezba5.Controllers;
using LabVezba5.Models;

namespace LabVezba5
{
    public partial class GameForm : Form, IView
    {
        private IController controller;
        private Deck deck;

        public IController Controller
        {
            get { return this.controller; }
            set { this.controller = value; }
        }

        public void AddListener(IController controller)
        {
            this.controller = controller;
        }

        public GameForm()
        {
            InitializeComponent();
        }

        public GameForm(int type, int deck, int startPoints)
            : this()
        {
            if (deck == 0)
                this.deck = new Deck(0);
            else
                this.deck = new Deck(1);

            if (type == 0)
            {
                this.controller = new StandardController(this.deck, this);
                btnSeeCC.Enabled = false;
            }
            else
            {
                this.controller = new TexasController(this.deck, this);
                cbxReplace.Enabled = false;
                btnReplace.Enabled = false;
            }

            lblPoints.Text = startPoints.ToString();
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
