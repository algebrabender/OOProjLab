using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Methodes
        DialogResult ZatvaranjeForme()
        {
            return MessageBox.Show("Da li ste sigurni da zelite da zatvorite formu?", "Obavestenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void ucitavanjePodataka()
        {
            dgvVozaci.DataSource = ListaVozaca.Instance.ListaVozacaValues.ToList();

            if (dgvVozaci.RowCount > 0)
            {

                for (int i = 0; i < dgvVozaci.ColumnCount; i++)
                {
                    if (dgvVozaci.Columns[i].Name == "MestoIzdavanja")
                        dgvVozaci.Columns[i].Visible = false;
                    if (dgvVozaci.Columns[i].Name == "DatumRodjenja")
                        dgvVozaci.Columns[i].Visible = false;
                    if (dgvVozaci.Columns[i].Name == "DozvolaOd")
                        dgvVozaci.Columns[i].Visible = false;
                    if (dgvVozaci.Columns[i].Name == "DozvolaDo")
                        dgvVozaci.Columns[i].Visible = false;
                    if (dgvVozaci.Columns[i].Name == "Pol")
                        dgvVozaci.Columns[i].Visible = false;
                    if (dgvVozaci.Columns[i].Name == "Liste")
                        dgvVozaci.Columns[i].Visible = false;
                    if (dgvVozaci.Columns[i].Name == "PutanjaDoSlike")
                        dgvVozaci.Columns[i].Visible = false;
                    if (dgvVozaci.Columns[i].Name == "Zabrane")
                        dgvVozaci.Columns[i].Visible = false;
                }

                btnObrisi.Enabled = true;
                btnIzmeni.Enabled = true;
            }
            else
            {
                btnObrisi.Enabled = false;
                btnIzmeni.Enabled = false;
            }
        }

        #endregion

        #region EventHandlers

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnObrisi.Enabled = false;
            btnIzmeni.Enabled = false;
            lblVremeDatum.Text = String.Empty;

            DialogResult dlg = MessageBox.Show("Da li zelite da ucitate podatke iz fajla?", "Obavestenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.Yes)
            {
                OpenFileDialog fileDlg = new OpenFileDialog(); ;
                fileDlg.ShowDialog();
                String putanja = fileDlg.FileName;
                if (putanja != "")
                {
                    ListaVozaca.Instance.izFajla(putanja);
                    ucitavanjePodataka();
                }
                else
                    fileDlg.ShowDialog();
            }

            tmrVremeIDatum.Start();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Da li zelite da sacuvate podatke u fajl?", "Obavestenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.Yes)
            {
                OpenFileDialog fileDlg = new OpenFileDialog(); ;
                fileDlg.ShowDialog();
                String putanja = fileDlg.FileName;
                if (putanja != "")
                    ListaVozaca.Instance.uFajl(putanja);
                else
                    fileDlg.ShowDialog();
            }

            if (ZatvaranjeForme() == DialogResult.No)
                e.Cancel = true;
        }

        private void tmrVremeIDatum_Tick(object sender, EventArgs e)
        {
            lblVremeDatum.Text = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy.");
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var temp = new VozacForm();

            DialogResult dlg = temp.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                ucitavanjePodataka();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvVozaci.SelectedRows.Count == 0)
                return;

            int selectedRow = dgvVozaci.SelectedRows[0].Index;
            String brDozvole = (String)dgvVozaci["BrojVozackeDozvole", selectedRow].Value;

            //selektovani vozac za izmenu
            Vozac v = ListaVozaca.Instance.GetVozac(brDozvole);

            var temp = new VozacForm();
            temp.Vozac = v;

            DialogResult dlg = temp.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                ucitavanjePodataka();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvVozaci.SelectedRows.Count == 0)
                return;

            DialogResult dlg = MessageBox.Show("Da li zelite da obrisete izabrani red?", "Obavestenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.No)
                return;

            int selectedRow = dgvVozaci.SelectedRows[0].Index;
            String brDozvole = (String)dgvVozaci["BrojVozackeDozvole", selectedRow].Value;

            if (ListaVozaca.Instance.brisanjeVozaca(brDozvole))
                MessageBox.Show("Vozac je uspesno izbrisan", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Vozac nije uspesno izbrisan", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //za refreshovanje liste
            ucitavanjePodataka();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            ListaVozaca.Instance.sortiranje();
            ucitavanjePodataka();
        }

        private void cmboxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboxSort.SelectedIndex == 0)
            {
                ListaVozaca.Instance.SortListDelegate = delegate (List<Vozac> lista)
                {
                    ListaVozaca.Instance.ListaVozacaValues.Sort((x, y) => x.BrojVozackeDozvole.CompareTo(y.BrojVozackeDozvole));
                    MessageBox.Show("Lista je sortirana po Broju vozacke dozvole", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
            }

            if (cmboxSort.SelectedIndex == 1)
            {
                ListaVozaca.Instance.SortListDelegate = delegate (List<Vozac> lista)
                {
                    ListaVozaca.Instance.ListaVozacaValues.Sort((x, y) => x.Ime.CompareTo(y.Ime));
                    MessageBox.Show("Lista je sortirana po Imenu", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
            }

            if (cmboxSort.SelectedIndex == 2)
            {
                ListaVozaca.Instance.SortListDelegate = delegate (List<Vozac> lista)
                {
                    ListaVozaca.Instance.ListaVozacaValues.Sort((x, y) => x.Prezime.CompareTo(y.Prezime));
                    MessageBox.Show("Lista je sortirana po Prezimenu", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
            }
        }

        private void dgvVozaci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //selektovanje bilo koje cell selektuje ceo red
            int index = e.RowIndex;
            dgvVozaci.Rows[index].Selected = true;
        }

        #endregion
    }
}
