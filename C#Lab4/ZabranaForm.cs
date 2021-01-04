﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Podaci;

namespace LabVezba4
{
    public partial class ZabranaForm : Form
    {
        #region Properties

        public ListaKategorija ListaKategorija
        {
            get;
            set;
        }

        #endregion

        #region Constructors

        public ZabranaForm()
        {
            InitializeComponent();
        }

        public ZabranaForm(ListaKategorija liste) : this()
        {
            ListaKategorija = liste;
        }

        #endregion

        #region Methodes

        private bool dodavanje()
        {
            string dtOd = dtDatumOd.Value.ToString("dd.MM.yyy");
            string dtDo = dtDatumDo.Value.ToString("dd.MM.yyy");
            Kategorija k = new Kategorija(cmboxKategorije.Text, dtOd, dtDo);

            return ListaKategorija.dodavanjeZabrane(k);
        }

        #endregion

        #region EventHandlers

        private void ZabranaForm_Load(object sender, EventArgs e)
        {
            foreach(Kategorija k in ListaKategorija.ListaKategorijaValues)
            {
                cmboxKategorije.Items.Add(k.Tip);
            }
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (!dodavanje())
            {
                MessageBox.Show("Dodavanje nije bilo uspesno", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Dodavanje je uspesno", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Forma ce biti zatvorena", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        #endregion
    }
}
