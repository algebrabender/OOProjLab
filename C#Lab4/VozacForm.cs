using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Extensions;
using Podaci;

namespace LabVezba4
{
    public partial class VozacForm : Form
    {
        #region Properties

        public Vozac Vozac
        {
            get;
            set;
        }

        //zbog lista kateogrija i zabrana koje je potrebno napraviti na pocetku(pozivom praznog konstrukotra vozaca)
        //potreban indikator da li radimo sa novim vozacom ili ne
        public bool Novi
        {
            get;
            set;
        }

        #endregion

        #region Constructors

        public VozacForm()
        {
            InitializeComponent();
        }

        //ukoliko je izmena vozaca
        public VozacForm(Vozac v) : this()
        {
            Vozac = v;
            btnProsledi.Text = "Izmeni";
        }

        #endregion

        #region Methodes

        private bool validacija()
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Polje Ime ne sme biti prazno", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (String.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Polje Prezime ne sme biti prazno", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (String.IsNullOrEmpty(txtDozvola.Text))
            {
                MessageBox.Show("Polje Broj vozacke dozvole ne sme biti prazno", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (String.IsNullOrEmpty(txtMesto.Text))
            {
                MessageBox.Show("Polje Mesto ne sme biti prazno", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (String.IsNullOrEmpty(cmboxPol.Text))
            {
                MessageBox.Show("Pol mora biti izabran", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if(picboxSlika.Image == null)
            {
                MessageBox.Show("Slika mora biti izabrna", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool dodavanje()
        {
            string dtRodj = dtDatumOd.Value.ToString("dd.MM.yyy");
            string dtOd = dtDatumOd.Value.ToString("dd.MM.yyy");
            string dtDo = dtDatumDo.Value.ToString("dd.MM.yyy");
            Vozac v = new Vozac(txtIme.Text, txtPrezime.Text, txtDozvola.Text,
                dtRodj, dtOd, dtDo, txtMesto.Text, cmboxPol.Text, picboxSlika.ImageLocation);
            //povezujemo liste sa vozacom
            v.Liste = Vozac.Liste;

            if (dgvKategorije.RowCount > 0)
            {

                for (int i = 0; i < dgvKategorije.RowCount; i++)
                {
                    Kategorija k = new Kategorija((String)dgvKategorije["Tip", i].Value,
                        (String)dgvKategorije["DatumOd", i].Value, (String)dgvKategorije["DatumDo", i].Value);
                    Vozac.Liste.dodavanjeKategorije(k);
                }
            }

            return ListaVozaca.Instance.dodavanjeVozaca(v);
        }

        private bool izmena()
        {
            string dtRodj = dtDatumOd.Value.ToString("dd.MM.yyy");
            string dtOd = dtDatumOd.Value.ToString("dd.MM.yyy");
            string dtDo = dtDatumDo.Value.ToString("dd.MM.yyy");
            Vozac v = new Vozac(txtIme.Text, txtPrezime.Text, txtDozvola.Text,
                dtRodj, dtOd, dtDo, txtMesto.Text, cmboxPol.Text, picboxSlika.ImageLocation);

            return ListaVozaca.Instance.menjanjeVozaca(v);
        }

        private void podaciUKontrole()
        {
            txtIme.Text = Vozac.Ime;
            txtPrezime.Text = Vozac.Prezime;
            txtDozvola.Text = Vozac.BrojVozackeDozvole;
            txtMesto.Text = Vozac.MestoIzdavanja;
            dtRodjenje.Value = Convert.ToDateTime(Vozac.DatumRodjenja);
            dtDatumOd.Value = Convert.ToDateTime(Vozac.DozvolaOd);
            dtDatumDo.Value = Convert.ToDateTime(Vozac.DozvolaDo);
            cmboxPol.Text = Vozac.Pol;
            picboxSlika.Image = Image.FromFile(Vozac.PutanjaDoSlike);

            txtDozvola.Enabled = false;
            btnProsledi.Text = "Izmeni";
        }

        private void ucitavanjePodataka()
        {
            dgvKategorije.DataSource = Vozac.Liste.ListaKategorijaValues.ToList();

            if (dgvKategorije.RowCount > 0)
                btnObrisiKategoriju.Enabled = true;
            else
                btnObrisiKategoriju.Enabled = false;

            dgvZabrane.DataSource = Vozac.Liste.ListaZabranaValues.ToList();

            if (dgvZabrane.RowCount > 0)
                btnObrisiZabranu.Enabled = true;
            else
                btnObrisiZabranu.Enabled = false;
        }

        #endregion

        #region EventHandlers

        private void VozacForm_Load(object sender, EventArgs e)
        {
            if (Vozac != null) //ako je forma pozvana radi izmena
            {
                podaciUKontrole();
                ucitavanjePodataka();
                Novi = false;
            }
            else
            {
                Vozac = new Vozac();
                Novi = true;
            }
        }

        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Mozete uneti samo karaktere", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Mozete uneti samo karaktere", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtDozvola_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Mozete uneti samo brojeve", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtIme_Leave(object sender, EventArgs e)
        {
            txtIme.Text = txtIme.Text.FirstLetterUpper();
        }

        private void txtPrezime_Leave(object sender, EventArgs e)
        {
            txtPrezime.Text = txtPrezime.Text.FirstLetterUpper();
        }

        private void txtMesto_Leave(object sender, EventArgs e)
        {
            txtMesto.Text = txtMesto.Text.FirstLetterUpper();
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog(); ;
            dlg.ShowDialog();
            String putanja = dlg.FileName;
            if (putanja != "")
            {
                picboxSlika.Image = Image.FromFile(putanja);
                picboxSlika.ImageLocation = putanja;
                MessageBox.Show("Slika je uspesno dodata", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Slika je neuspesno dodata", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                if (Novi == true) //potrebno dodati vozaca
                {
                    if (!dodavanje()) //ako nije uspesno dodavanje
                    {
                        MessageBox.Show("Dodavanje nije bilo uspesno", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtIme.Focus();

                        return;
                    }

                    MessageBox.Show("Dodavanje je uspesno", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else //potrebno izmeniti vozaca
                {
                    if (!izmena()) //ako neuspesno menjanje
                    {
                        MessageBox.Show("Izmena nije bilo uspesno", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtIme.Focus();

                        return;
                    }

                    MessageBox.Show("Izmena je uspesna", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close(); //zatvara se forma
                this.DialogResult = System.Windows.Forms.DialogResult.OK; //slanje potvrdnog odgovara
            }

            //ako nije uspesna validacija 
            return;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Forma ce biti zatvorena", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            var temp = new KategorijaForm(Vozac.Liste);

            DialogResult dlg = temp.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                ucitavanjePodataka();
        }

        private void btnObrisiKategoriju_Click(object sender, EventArgs e)
        {
            if (dgvKategorije.SelectedRows.Count == 0)
                return;

            DialogResult dlg = MessageBox.Show("Da li zelite da obrisete izabrani red?", "Obavestenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.No)
                return;

            int selectedRow = dgvKategorije.SelectedRows[0].Index;
            String tip = (String)dgvKategorije["Tip", selectedRow].Value;

            if (Vozac.Liste.brisanjeKategorije(tip))
                MessageBox.Show("Kategorija je uspesno izbrisana", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Kategorija nije uspesno izbrisana", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ucitavanjePodataka();
        }

        private void btnDodajZabranu_Click(object sender, EventArgs e)
        {
            var temp = new ZabranaForm(Vozac.Liste);

            DialogResult dlg = temp.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                ucitavanjePodataka();
        }

        private void btnObrisiZabranu_Click(object sender, EventArgs e)
        {
            if (dgvZabrane.SelectedRows.Count == 0)
                return;

            DialogResult dlg = MessageBox.Show("Da li zelite da obrisete izabrani red?", "Obavestenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.No)
                return;

            int selectedRow = dgvZabrane.SelectedRows[0].Index;
            String tip = (String)dgvZabrane["Tip", selectedRow].Value;

            if (Vozac.Liste.brisanjeZabrane(tip))
                MessageBox.Show("Zabrana je uspesno izbrisana", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Zabrana nije uspesno izbrisana", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ucitavanjePodataka();
        }

        private void dgvKategorije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //selektovanje bilo koje cell selektuje ceo red
            int index = e.RowIndex;
            dgvKategorije.Rows[index].Selected = true;
        }

        private void dgvZabrane_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //selektovanje bilo koje cell selektuje ceo red
            int index = e.RowIndex;
            dgvZabrane.Rows[index].Selected = true;
        }

        #endregion
    }
}
