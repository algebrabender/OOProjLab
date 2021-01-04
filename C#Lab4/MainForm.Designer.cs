
namespace LabVezba4
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.lblVremeDatum = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.cmboxSort = new System.Windows.Forms.ComboBox();
            this.grboxLista = new System.Windows.Forms.GroupBox();
            this.dgvVozaci = new System.Windows.Forms.DataGridView();
            this.tmrVremeIDatum = new System.Windows.Forms.Timer(this.components);
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.grboxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozaci)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVremeDatum
            // 
            this.lblVremeDatum.AutoSize = true;
            this.lblVremeDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVremeDatum.Location = new System.Drawing.Point(16, 10);
            this.lblVremeDatum.Name = "lblVremeDatum";
            this.lblVremeDatum.Size = new System.Drawing.Size(73, 13);
            this.lblVremeDatum.TabIndex = 0;
            this.lblVremeDatum.Text = "vreme i datum";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(302, 5);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sortiraj";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cmboxSort
            // 
            this.cmboxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxSort.FormattingEnabled = true;
            this.cmboxSort.Items.AddRange(new object[] {
            "Broj vozacke dozvole",
            "Ime",
            "Prezime"});
            this.cmboxSort.Location = new System.Drawing.Point(383, 7);
            this.cmboxSort.Name = "cmboxSort";
            this.cmboxSort.Size = new System.Drawing.Size(181, 21);
            this.cmboxSort.TabIndex = 2;
            this.cmboxSort.SelectedIndexChanged += new System.EventHandler(this.cmboxSort_SelectedIndexChanged);
            // 
            // grboxLista
            // 
            this.grboxLista.Controls.Add(this.dgvVozaci);
            this.grboxLista.Location = new System.Drawing.Point(16, 41);
            this.grboxLista.Name = "grboxLista";
            this.grboxLista.Size = new System.Drawing.Size(548, 339);
            this.grboxLista.TabIndex = 3;
            this.grboxLista.TabStop = false;
            this.grboxLista.Text = "Lista vozaca";
            // 
            // dgvVozaci
            // 
            this.dgvVozaci.AllowUserToDeleteRows = false;
            this.dgvVozaci.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvVozaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozaci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVozaci.Location = new System.Drawing.Point(3, 16);
            this.dgvVozaci.Name = "dgvVozaci";
            this.dgvVozaci.ReadOnly = true;
            this.dgvVozaci.Size = new System.Drawing.Size(542, 320);
            this.dgvVozaci.TabIndex = 0;
            this.dgvVozaci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVozaci_CellClick);
            // 
            // tmrVremeIDatum
            // 
            this.tmrVremeIDatum.Interval = 1000;
            this.tmrVremeIDatum.Tick += new System.EventHandler(this.tmrVremeIDatum_Tick);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Image = global::LabVezba4.Properties.Resources.trashcan;
            this.btnObrisi.Location = new System.Drawing.Point(462, 389);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(97, 49);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obrisi vozaca";
            this.btnObrisi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Image = global::LabVezba4.Properties.Resources.pen;
            this.btnIzmeni.Location = new System.Drawing.Point(119, 389);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(97, 49);
            this.btnIzmeni.TabIndex = 5;
            this.btnIzmeni.Text = "Izmeni vozaca";
            this.btnIzmeni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Image = global::LabVezba4.Properties.Resources.add;
            this.btnDodaj.Location = new System.Drawing.Point(16, 389);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(97, 49);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj vozaca";
            this.btnDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.grboxLista);
            this.Controls.Add(this.cmboxSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblVremeDatum);
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "MainForm";
            this.Text = "Lista vozaca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grboxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVremeDatum;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cmboxSort;
        private System.Windows.Forms.GroupBox grboxLista;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dgvVozaci;
        private System.Windows.Forms.Timer tmrVremeIDatum;
    }
}

