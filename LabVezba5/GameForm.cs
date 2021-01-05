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
        #region Attributes

        private IController controller;
        private Deck deck;

        #endregion

        #region Constructors

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
                this.controller = new StandardController(this.deck, this, startPoints);
                btnSeeCC.Enabled = false;
                lblText.Text = "You can either Replace cards or Deal new set of cards\nIf you want to finish game click on Stop";
            }
            else
            {
                this.controller = new TexasController(this.deck, this, startPoints);
                cbxReplace.Enabled = false;
                btnReplace.Enabled = false;
                lblText.Text = "You can either See CC (1 by 1) or Deal new set of cards\nIf you want to finish game click on Stop";
            }
        }

        #endregion

        #region Interface Implemnetation 

        public void AddListener(IController controller)
        {
            this.controller = controller;
        }

        public void SetPoints(int points)
        {
            lblPoints.Text = points.ToString();
        }

        public int GetBetAmount()
        {
            return Int32.Parse(tbxBetAmount.Text);
        }

        public List<PictureBox> GetPictureBoxes()
        {
            List<PictureBox> list = new List<PictureBox>();
            list.Add(pbxFirst);
            list.Add(pbxSecond);
            list.Add(pbxThird);
            list.Add(pbxFourth);
            list.Add(pbxFifth);

            return list;
        }

        #endregion

        #region Event Handlers

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            if (tbxBetAmount.Text == "")
            {
                MessageBox.Show("Bet amount not entered", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!controller.Draw())
            {
                if (this.controller.GetPoints() == 0)
                {
                    MessageBox.Show("No more points. Game has ended", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No more cards for dealing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnDeal.Enabled = false;
                    btnReplace.Enabled = false;
                    cbxReplace.Enabled = false;
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.controller.GameOver();

            lblPoints.Text = this.controller.GetPoints().ToString();

            MessageBox.Show("The Game has ended\nFinal score: " + lblPoints.Text, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (cbxReplace.SelectedIndex == -1)
            {
                MessageBox.Show("Number must be selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.controller.ReplaceToggle(cbxReplace.SelectedIndex);
            cbxReplace.SelectedIndex = -1;
        }

        private void btnSeeCC_Click(object sender, EventArgs e)
        {
            this.controller.ReplaceToggle(1);
        }

        private void tbxBetAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion
    }
}
