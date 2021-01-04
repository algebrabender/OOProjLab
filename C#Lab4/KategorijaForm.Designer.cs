
namespace LabVezba4
{
    partial class KategorijaForm
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
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.lblVazenjeDo = new System.Windows.Forms.Label();
            this.lblVazenjeOd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboxKategorije = new System.Windows.Forms.ComboBox();
            this.dtDatumDo = new System.Windows.Forms.DateTimePicker();
            this.dtDatumOd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(172, 111);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 5;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(53, 111);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(75, 23);
            this.btnProsledi.TabIndex = 4;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // lblVazenjeDo
            // 
            this.lblVazenjeDo.AutoSize = true;
            this.lblVazenjeDo.Location = new System.Drawing.Point(84, 84);
            this.lblVazenjeDo.Name = "lblVazenjeDo";
            this.lblVazenjeDo.Size = new System.Drawing.Size(22, 13);
            this.lblVazenjeDo.TabIndex = 14;
            this.lblVazenjeDo.Text = "do:";
            // 
            // lblVazenjeOd
            // 
            this.lblVazenjeOd.AutoSize = true;
            this.lblVazenjeOd.Location = new System.Drawing.Point(50, 58);
            this.lblVazenjeOd.Name = "lblVazenjeOd";
            this.lblVazenjeOd.Size = new System.Drawing.Size(56, 13);
            this.lblVazenjeOd.TabIndex = 0;
            this.lblVazenjeOd.Text = "Datum od:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorija:";
            // 
            // cmboxKategorije
            // 
            this.cmboxKategorije.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxKategorije.FormattingEnabled = true;
            this.cmboxKategorije.Items.AddRange(new object[] {
            "AM",
            "A1",
            "A2",
            "A",
            "B1",
            "B",
            "BE",
            "C1",
            "C1E",
            "C",
            "CE",
            "D1",
            "D1E",
            "D",
            "DE",
            "F",
            "M"});
            this.cmboxKategorije.Location = new System.Drawing.Point(121, 25);
            this.cmboxKategorije.Name = "cmboxKategorije";
            this.cmboxKategorije.Size = new System.Drawing.Size(126, 21);
            this.cmboxKategorije.TabIndex = 1;
            // 
            // dtDatumDo
            // 
            this.dtDatumDo.CustomFormat = "dd.MM.yyyy";
            this.dtDatumDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDatumDo.Location = new System.Drawing.Point(121, 78);
            this.dtDatumDo.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtDatumDo.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtDatumDo.Name = "dtDatumDo";
            this.dtDatumDo.Size = new System.Drawing.Size(126, 20);
            this.dtDatumDo.TabIndex = 3;
            this.dtDatumDo.Value = new System.DateTime(2020, 12, 21, 0, 0, 0, 0);
            // 
            // dtDatumOd
            // 
            this.dtDatumOd.CustomFormat = "dd.MM.yyyy";
            this.dtDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDatumOd.Location = new System.Drawing.Point(121, 52);
            this.dtDatumOd.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtDatumOd.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtDatumOd.Name = "dtDatumOd";
            this.dtDatumOd.Size = new System.Drawing.Size(126, 20);
            this.dtDatumOd.TabIndex = 2;
            this.dtDatumOd.Value = new System.DateTime(2020, 12, 21, 0, 0, 0, 0);
            // 
            // KategorijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 171);
            this.Controls.Add(this.dtDatumOd);
            this.Controls.Add(this.dtDatumDo);
            this.Controls.Add(this.cmboxKategorije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVazenjeDo);
            this.Controls.Add(this.lblVazenjeOd);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnProsledi);
            this.MaximumSize = new System.Drawing.Size(320, 210);
            this.MinimumSize = new System.Drawing.Size(320, 210);
            this.Name = "KategorijaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kateogrija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Label lblVazenjeDo;
        private System.Windows.Forms.Label lblVazenjeOd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboxKategorije;
        private System.Windows.Forms.DateTimePicker dtDatumDo;
        private System.Windows.Forms.DateTimePicker dtDatumOd;
    }
}