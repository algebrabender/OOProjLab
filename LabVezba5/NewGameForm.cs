using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabVezba5
{
    public partial class NewGameForm : Form
    {
        public NewGameForm()
        {
            InitializeComponent();
        }

        #region Methodes

        private bool Validation()
        {
            if (tbxPoints.Text == "")
            {
                MessageBox.Show("Starting points not entered", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (tbxBetAmount.Text == "")
            {
                MessageBox.Show("Bet amount not entered", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        #endregion

        #region Event Handlers

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(Validation())
            {
                var game = new GameForm(Int32.Parse(tbxPoints.Text), Int32.Parse(tbxBetAmount.Text));

                this.Hide();

                DialogResult dlg = game.ShowDialog();

                //da bi se zatvorilo kad zatvorimo main game
                if (dlg == System.Windows.Forms.DialogResult.OK)
                    this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxPoints_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
