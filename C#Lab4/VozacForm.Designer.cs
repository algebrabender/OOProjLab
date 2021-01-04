
namespace LabVezba4
{
    partial class VozacForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grboxPodaci = new System.Windows.Forms.GroupBox();
            this.dtDatumDo = new System.Windows.Forms.DateTimePicker();
            this.dtDatumOd = new System.Windows.Forms.DateTimePicker();
            this.dtRodjenje = new System.Windows.Forms.DateTimePicker();
            this.txtMesto = new System.Windows.Forms.TextBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.picboxSlika = new System.Windows.Forms.PictureBox();
            this.cmboxPol = new System.Windows.Forms.ComboBox();
            this.txtDozvola = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblPol = new System.Windows.Forms.Label();
            this.lblMesto = new System.Windows.Forms.Label();
            this.lblBrDozvole = new System.Windows.Forms.Label();
            this.lblVazenjeDo = new System.Windows.Forms.Label();
            this.lblVazenjeOd = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.grboxKategorija = new System.Windows.Forms.GroupBox();
            this.btnObrisiKategoriju = new System.Windows.Forms.Button();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.dgvKategorije = new System.Windows.Forms.DataGridView();
            this.grboxZabrana = new System.Windows.Forms.GroupBox();
            this.btnObrisiZabranu = new System.Windows.Forms.Button();
            this.btnDodajZabranu = new System.Windows.Forms.Button();
            this.dgvZabrane = new System.Windows.Forms.DataGridView();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.grboxPodaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSlika)).BeginInit();
            this.grboxKategorija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).BeginInit();
            this.grboxZabrana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZabrane)).BeginInit();
            this.SuspendLayout();
            // 
            // grboxPodaci
            // 
            this.grboxPodaci.Controls.Add(this.dtDatumDo);
            this.grboxPodaci.Controls.Add(this.dtDatumOd);
            this.grboxPodaci.Controls.Add(this.dtRodjenje);
            this.grboxPodaci.Controls.Add(this.txtMesto);
            this.grboxPodaci.Controls.Add(this.btnDodajSliku);
            this.grboxPodaci.Controls.Add(this.picboxSlika);
            this.grboxPodaci.Controls.Add(this.cmboxPol);
            this.grboxPodaci.Controls.Add(this.txtDozvola);
            this.grboxPodaci.Controls.Add(this.txtPrezime);
            this.grboxPodaci.Controls.Add(this.txtIme);
            this.grboxPodaci.Controls.Add(this.lblPol);
            this.grboxPodaci.Controls.Add(this.lblMesto);
            this.grboxPodaci.Controls.Add(this.lblBrDozvole);
            this.grboxPodaci.Controls.Add(this.lblVazenjeDo);
            this.grboxPodaci.Controls.Add(this.lblVazenjeOd);
            this.grboxPodaci.Controls.Add(this.lblDatumRodjenja);
            this.grboxPodaci.Controls.Add(this.lblPrezime);
            this.grboxPodaci.Controls.Add(this.lblIme);
            this.grboxPodaci.Location = new System.Drawing.Point(13, 12);
            this.grboxPodaci.Name = "grboxPodaci";
            this.grboxPodaci.Size = new System.Drawing.Size(452, 264);
            this.grboxPodaci.TabIndex = 0;
            this.grboxPodaci.TabStop = false;
            this.grboxPodaci.Text = "Osnovni podaci";
            // 
            // dtDatumDo
            // 
            this.dtDatumDo.CustomFormat = "dd.MM.yyyy";
            this.dtDatumDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDatumDo.Location = new System.Drawing.Point(135, 138);
            this.dtDatumDo.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtDatumDo.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtDatumDo.Name = "dtDatumDo";
            this.dtDatumDo.Size = new System.Drawing.Size(126, 20);
            this.dtDatumDo.TabIndex = 5;
            this.dtDatumDo.Value = new System.DateTime(2020, 12, 21, 0, 0, 0, 0);
            // 
            // dtDatumOd
            // 
            this.dtDatumOd.CustomFormat = "dd.MM.yyyy";
            this.dtDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDatumOd.Location = new System.Drawing.Point(135, 115);
            this.dtDatumOd.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtDatumOd.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtDatumOd.Name = "dtDatumOd";
            this.dtDatumOd.Size = new System.Drawing.Size(126, 20);
            this.dtDatumOd.TabIndex = 4;
            this.dtDatumOd.Value = new System.DateTime(2020, 12, 21, 0, 0, 0, 0);
            // 
            // dtRodjenje
            // 
            this.dtRodjenje.CustomFormat = "dd.MM.yyyy";
            this.dtRodjenje.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRodjenje.Location = new System.Drawing.Point(135, 89);
            this.dtRodjenje.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtRodjenje.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtRodjenje.Name = "dtRodjenje";
            this.dtRodjenje.Size = new System.Drawing.Size(126, 20);
            this.dtRodjenje.TabIndex = 3;
            this.dtRodjenje.Value = new System.DateTime(2020, 12, 21, 0, 0, 0, 0);
            // 
            // txtMesto
            // 
            this.txtMesto.Location = new System.Drawing.Point(135, 190);
            this.txtMesto.Name = "txtMesto";
            this.txtMesto.Size = new System.Drawing.Size(126, 20);
            this.txtMesto.TabIndex = 7;
            this.txtMesto.Leave += new System.EventHandler(this.txtMesto_Leave);
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(323, 153);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(75, 23);
            this.btnDodajSliku.TabIndex = 9;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // picboxSlika
            // 
            this.picboxSlika.Location = new System.Drawing.Point(302, 27);
            this.picboxSlika.Name = "picboxSlika";
            this.picboxSlika.Size = new System.Drawing.Size(120, 120);
            this.picboxSlika.TabIndex = 16;
            this.picboxSlika.TabStop = false;
            // 
            // cmboxPol
            // 
            this.cmboxPol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxPol.FormattingEnabled = true;
            this.cmboxPol.Items.AddRange(new object[] {
            "F",
            "M",
            "Ostalo"});
            this.cmboxPol.Location = new System.Drawing.Point(136, 217);
            this.cmboxPol.Name = "cmboxPol";
            this.cmboxPol.Size = new System.Drawing.Size(125, 21);
            this.cmboxPol.TabIndex = 8;
            // 
            // txtDozvola
            // 
            this.txtDozvola.Location = new System.Drawing.Point(135, 165);
            this.txtDozvola.Name = "txtDozvola";
            this.txtDozvola.Size = new System.Drawing.Size(126, 20);
            this.txtDozvola.TabIndex = 6;
            this.txtDozvola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDozvola_KeyPress);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(135, 58);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(126, 20);
            this.txtPrezime.TabIndex = 2;
            this.txtPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrezime_KeyPress);
            this.txtPrezime.Leave += new System.EventHandler(this.txtPrezime_Leave);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(135, 27);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(126, 20);
            this.txtIme.TabIndex = 1;
            this.txtIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIme_KeyPress);
            this.txtIme.Leave += new System.EventHandler(this.txtIme_Leave);
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.Location = new System.Drawing.Point(102, 220);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(25, 13);
            this.lblPol.TabIndex = 0;
            this.lblPol.Text = "Pol:";
            // 
            // lblMesto
            // 
            this.lblMesto.AutoSize = true;
            this.lblMesto.Location = new System.Drawing.Point(42, 193);
            this.lblMesto.Name = "lblMesto";
            this.lblMesto.Size = new System.Drawing.Size(87, 13);
            this.lblMesto.TabIndex = 0;
            this.lblMesto.Text = "Mesto izdavanja:";
            // 
            // lblBrDozvole
            // 
            this.lblBrDozvole.AutoSize = true;
            this.lblBrDozvole.Location = new System.Drawing.Point(17, 168);
            this.lblBrDozvole.Name = "lblBrDozvole";
            this.lblBrDozvole.Size = new System.Drawing.Size(112, 13);
            this.lblBrDozvole.TabIndex = 0;
            this.lblBrDozvole.Text = "Broj vozacke dozvole:";
            // 
            // lblVazenjeDo
            // 
            this.lblVazenjeDo.AutoSize = true;
            this.lblVazenjeDo.Location = new System.Drawing.Point(107, 144);
            this.lblVazenjeDo.Name = "lblVazenjeDo";
            this.lblVazenjeDo.Size = new System.Drawing.Size(22, 13);
            this.lblVazenjeDo.TabIndex = 0;
            this.lblVazenjeDo.Text = "do:";
            // 
            // lblVazenjeOd
            // 
            this.lblVazenjeOd.AutoSize = true;
            this.lblVazenjeOd.Location = new System.Drawing.Point(26, 121);
            this.lblVazenjeOd.Name = "lblVazenjeOd";
            this.lblVazenjeOd.Size = new System.Drawing.Size(103, 13);
            this.lblVazenjeOd.TabIndex = 0;
            this.lblVazenjeOd.Text = "Vazenje dozvole od:";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(48, 95);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(81, 13);
            this.lblDatumRodjenja.TabIndex = 0;
            this.lblDatumRodjenja.Text = "Datum rodjenja:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(82, 61);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 0;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(102, 30);
            this.lblIme.Name = "lblIme";
            this.lblIme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // grboxKategorija
            // 
            this.grboxKategorija.Controls.Add(this.btnObrisiKategoriju);
            this.grboxKategorija.Controls.Add(this.btnDodajKategoriju);
            this.grboxKategorija.Controls.Add(this.dgvKategorije);
            this.grboxKategorija.Location = new System.Drawing.Point(13, 282);
            this.grboxKategorija.Name = "grboxKategorija";
            this.grboxKategorija.Size = new System.Drawing.Size(452, 200);
            this.grboxKategorija.TabIndex = 1;
            this.grboxKategorija.TabStop = false;
            this.grboxKategorija.Text = "Kategorija";
            // 
            // btnObrisiKategoriju
            // 
            this.btnObrisiKategoriju.Image = global::LabVezba4.Properties.Resources.trashcan;
            this.btnObrisiKategoriju.Location = new System.Drawing.Point(349, 144);
            this.btnObrisiKategoriju.Name = "btnObrisiKategoriju";
            this.btnObrisiKategoriju.Size = new System.Drawing.Size(97, 49);
            this.btnObrisiKategoriju.TabIndex = 3;
            this.btnObrisiKategoriju.Text = "Obrisi kategoriju";
            this.btnObrisiKategoriju.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisiKategoriju.UseVisualStyleBackColor = true;
            this.btnObrisiKategoriju.Click += new System.EventHandler(this.btnObrisiKategoriju_Click);
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.Image = global::LabVezba4.Properties.Resources.add;
            this.btnDodajKategoriju.Location = new System.Drawing.Point(6, 144);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(148, 49);
            this.btnDodajKategoriju.TabIndex = 2;
            this.btnDodajKategoriju.Text = "Dodaj novu kategoriju";
            this.btnDodajKategoriju.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajKategoriju.UseVisualStyleBackColor = true;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // dgvKategorije
            // 
            this.dgvKategorije.AllowUserToDeleteRows = false;
            this.dgvKategorije.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategorije.Location = new System.Drawing.Point(6, 19);
            this.dgvKategorije.Name = "dgvKategorije";
            this.dgvKategorije.ReadOnly = true;
            this.dgvKategorije.Size = new System.Drawing.Size(440, 119);
            this.dgvKategorije.TabIndex = 1;
            this.dgvKategorije.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKategorije_CellClick);
            // 
            // grboxZabrana
            // 
            this.grboxZabrana.Controls.Add(this.btnObrisiZabranu);
            this.grboxZabrana.Controls.Add(this.btnDodajZabranu);
            this.grboxZabrana.Controls.Add(this.dgvZabrane);
            this.grboxZabrana.Location = new System.Drawing.Point(13, 488);
            this.grboxZabrana.Name = "grboxZabrana";
            this.grboxZabrana.Size = new System.Drawing.Size(452, 201);
            this.grboxZabrana.TabIndex = 2;
            this.grboxZabrana.TabStop = false;
            this.grboxZabrana.Text = "Zabrana upravljanja";
            // 
            // btnObrisiZabranu
            // 
            this.btnObrisiZabranu.Image = global::LabVezba4.Properties.Resources.trashcan;
            this.btnObrisiZabranu.Location = new System.Drawing.Point(349, 146);
            this.btnObrisiZabranu.Name = "btnObrisiZabranu";
            this.btnObrisiZabranu.Size = new System.Drawing.Size(91, 49);
            this.btnObrisiZabranu.TabIndex = 3;
            this.btnObrisiZabranu.Text = "Obrisi zabranu";
            this.btnObrisiZabranu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisiZabranu.UseVisualStyleBackColor = true;
            this.btnObrisiZabranu.Click += new System.EventHandler(this.btnObrisiZabranu_Click);
            // 
            // btnDodajZabranu
            // 
            this.btnDodajZabranu.Image = global::LabVezba4.Properties.Resources.add;
            this.btnDodajZabranu.Location = new System.Drawing.Point(6, 144);
            this.btnDodajZabranu.Name = "btnDodajZabranu";
            this.btnDodajZabranu.Size = new System.Drawing.Size(148, 49);
            this.btnDodajZabranu.TabIndex = 2;
            this.btnDodajZabranu.Text = "Dodaj novu zabranu";
            this.btnDodajZabranu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajZabranu.UseVisualStyleBackColor = true;
            this.btnDodajZabranu.Click += new System.EventHandler(this.btnDodajZabranu_Click);
            // 
            // dgvZabrane
            // 
            this.dgvZabrane.AllowUserToDeleteRows = false;
            this.dgvZabrane.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvZabrane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZabrane.Location = new System.Drawing.Point(6, 19);
            this.dgvZabrane.Name = "dgvZabrane";
            this.dgvZabrane.ReadOnly = true;
            this.dgvZabrane.Size = new System.Drawing.Size(440, 119);
            this.dgvZabrane.TabIndex = 1;
            this.dgvZabrane.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZabrane_CellClick);
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(148, 695);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(75, 23);
            this.btnProsledi.TabIndex = 3;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(257, 695);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 4;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // VozacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 741);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.grboxZabrana);
            this.Controls.Add(this.grboxKategorija);
            this.Controls.Add(this.grboxPodaci);
            this.MaximumSize = new System.Drawing.Size(500, 780);
            this.MinimumSize = new System.Drawing.Size(500, 780);
            this.Name = "VozacForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vozac";
            this.Load += new System.EventHandler(this.VozacForm_Load);
            this.grboxPodaci.ResumeLayout(false);
            this.grboxPodaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSlika)).EndInit();
            this.grboxKategorija.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).EndInit();
            this.grboxZabrana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZabrane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxPodaci;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.Label lblMesto;
        private System.Windows.Forms.Label lblBrDozvole;
        private System.Windows.Forms.Label lblVazenjeDo;
        private System.Windows.Forms.Label lblVazenjeOd;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.ComboBox cmboxPol;
        private System.Windows.Forms.TextBox txtDozvola;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.PictureBox picboxSlika;
        private System.Windows.Forms.GroupBox grboxKategorija;
        private System.Windows.Forms.DataGridView dgvKategorije;
        private System.Windows.Forms.Button btnObrisiKategoriju;
        private System.Windows.Forms.Button btnDodajKategoriju;
        private System.Windows.Forms.GroupBox grboxZabrana;
        private System.Windows.Forms.Button btnObrisiZabranu;
        private System.Windows.Forms.Button btnDodajZabranu;
        private System.Windows.Forms.DataGridView dgvZabrane;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.TextBox txtMesto;
        private System.Windows.Forms.DateTimePicker dtDatumDo;
        private System.Windows.Forms.DateTimePicker dtDatumOd;
        private System.Windows.Forms.DateTimePicker dtRodjenje;
    }
}