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

namespace LabVezba5
{
    public partial class GameForm : Form, IView
    {
        //koriscenje MVC patterna kao sto je bilo naznaceno u prvoj verziji lab vezbe

        #region Attributes

        private IController controller;
        private int count;
        private List<Image> selectedCards;

        #endregion

        #region Constructors

        public GameForm()
        {
            InitializeComponent();
        }

        public GameForm(int startPoints, int betAmount)
            : this()
        {
            this.controller = new StandardController(this, startPoints);
            tbxBetAmount.Text = betAmount.ToString();
            lblBetPoints.Text = betAmount.ToString();
            lblText.Text = "You can either Replace cards or Deal new set of cards.If you want to finish game click on Stop\nCards may change place due to checks";

            this.selectedCards = new List<Image>();
        }

        #endregion

        #region Interface Implementation 

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

        public void SetWonPoints(int points)
        {
            lblWonPoints.Text = points.ToString();
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

            lblBetPoints.Text = tbxBetAmount.Text;

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
                    btnCalc.Enabled = false;
                    btnReplace.Enabled = false;
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            lblPoints.Text = this.controller.GetPoints().ToString();

            MessageBox.Show("The Game has ended\nFinal score: " + lblPoints.Text, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            lblPoints.Text = this.controller.GetPoints().ToString();
            count = 0;
            this.selectedCards = new List<Image>();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            this.controller.Replace(count, selectedCards);
            count = 0;
            this.selectedCards = new List<Image>();
        }

        private void tbxBetAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pbxFirst_Click(object sender, EventArgs e)
        {
            if (count == 3)
            {
                MessageBox.Show("Only three cards can be selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.selectedCards.Contains(pbxFirst.Image))
            {
                MessageBox.Show("Card already selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            count++;
            this.selectedCards.Add(pbxFirst.Image);
        }

        private void pbxSecond_Click(object sender, EventArgs e)
        {
            if (count == 3)
            {
                MessageBox.Show("Only three cards can be selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.selectedCards.Contains(pbxSecond.Image))
            {
                MessageBox.Show("Card already selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            count++;
            this.selectedCards.Add(pbxSecond.Image);
        }

        private void pbxThird_Click(object sender, EventArgs e)
        {
            if (count == 3)
            {
                MessageBox.Show("Only three cards can be selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.selectedCards.Contains(pbxThird.Image))
            {
                MessageBox.Show("Card already selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            count++;
            this.selectedCards.Add(pbxThird.Image);
        }

        private void pbxFourth_Click(object sender, EventArgs e)
        {
            if (count == 3)
            {
                MessageBox.Show("Only three cards can be selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.selectedCards.Contains(pbxFourth.Image))
            {
                MessageBox.Show("Card already selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            count++;
            this.selectedCards.Add(pbxFourth.Image);
        }

        private void pbxFifth_Click(object sender, EventArgs e)
        {
            if (count == 3)
            {
                MessageBox.Show("Only three cards can be selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.selectedCards.Contains(pbxFifth.Image))
            {
                MessageBox.Show("Card already selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            count++;
            this.selectedCards.Add(pbxFifth.Image);
        }

        #endregion
    }
}
