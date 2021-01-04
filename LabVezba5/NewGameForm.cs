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

        private bool Validation()
        {
            if (tbxPoints.Text == "")
            {
                MessageBox.Show("Starting points not entered", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!rbnStandard.Checked && !rbnTexas.Checked)
            {
                MessageBox.Show("Type not chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!rbnStandardDeck.Checked && !rbnFrenchDeck.Checked)
            {
                MessageBox.Show("Deck type not chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(Validation())
            {
                int type = -1;
                int deck = -1;

                if (rbnStandard.Checked)
                    type = 0;

                if (rbnTexas.Checked)
                    type = 1;

                if (rbnStandardDeck.Checked)
                    deck = 0;

                if (rbnFrenchDeck.Checked)
                    deck = 1;

                var game = new GameForm(type, deck, Int32.Parse(tbxPoints.Text));

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
    }
}
