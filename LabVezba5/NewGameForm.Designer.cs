
namespace LabVezba5
{
    partial class NewGameForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxType = new System.Windows.Forms.GroupBox();
            this.gbxDeck = new System.Windows.Forms.GroupBox();
            this.lblType = new System.Windows.Forms.Label();
            this.rbnStandard = new System.Windows.Forms.RadioButton();
            this.rbnTexas = new System.Windows.Forms.RadioButton();
            this.rbnFrenchDeck = new System.Windows.Forms.RadioButton();
            this.rbnStandardDeck = new System.Windows.Forms.RadioButton();
            this.lblDeck = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.tbxPoints = new System.Windows.Forms.TextBox();
            this.gbxType.SuspendLayout();
            this.gbxDeck.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(218, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Game of Poker";
            // 
            // gbxType
            // 
            this.gbxType.Controls.Add(this.rbnTexas);
            this.gbxType.Controls.Add(this.rbnStandard);
            this.gbxType.Controls.Add(this.lblType);
            this.gbxType.Location = new System.Drawing.Point(12, 44);
            this.gbxType.Name = "gbxType";
            this.gbxType.Size = new System.Drawing.Size(249, 129);
            this.gbxType.TabIndex = 1;
            this.gbxType.TabStop = false;
            // 
            // gbxDeck
            // 
            this.gbxDeck.Controls.Add(this.rbnFrenchDeck);
            this.gbxDeck.Controls.Add(this.rbnStandardDeck);
            this.gbxDeck.Controls.Add(this.lblDeck);
            this.gbxDeck.Location = new System.Drawing.Point(311, 44);
            this.gbxDeck.Name = "gbxDeck";
            this.gbxDeck.Size = new System.Drawing.Size(261, 129);
            this.gbxDeck.TabIndex = 2;
            this.gbxDeck.TabStop = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(6, 16);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(144, 17);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Choose type of Poker";
            // 
            // rbnStandard
            // 
            this.rbnStandard.AutoSize = true;
            this.rbnStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnStandard.Location = new System.Drawing.Point(6, 61);
            this.rbnStandard.Name = "rbnStandard";
            this.rbnStandard.Size = new System.Drawing.Size(125, 21);
            this.rbnStandard.TabIndex = 2;
            this.rbnStandard.TabStop = true;
            this.rbnStandard.Text = "Standard Poker";
            this.rbnStandard.UseVisualStyleBackColor = true;
            // 
            // rbnTexas
            // 
            this.rbnTexas.AutoSize = true;
            this.rbnTexas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnTexas.Location = new System.Drawing.Point(6, 88);
            this.rbnTexas.Name = "rbnTexas";
            this.rbnTexas.Size = new System.Drawing.Size(160, 21);
            this.rbnTexas.TabIndex = 3;
            this.rbnTexas.TabStop = true;
            this.rbnTexas.Text = "Texas Hold’em Poker";
            this.rbnTexas.UseVisualStyleBackColor = true;
            // 
            // rbnFrenchDeck
            // 
            this.rbnFrenchDeck.AutoSize = true;
            this.rbnFrenchDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnFrenchDeck.Location = new System.Drawing.Point(6, 88);
            this.rbnFrenchDeck.Name = "rbnFrenchDeck";
            this.rbnFrenchDeck.Size = new System.Drawing.Size(175, 21);
            this.rbnFrenchDeck.TabIndex = 5;
            this.rbnFrenchDeck.TabStop = true;
            this.rbnFrenchDeck.Text = "French Deck (32 cards)";
            this.rbnFrenchDeck.UseVisualStyleBackColor = true;
            // 
            // rbnStandardDeck
            // 
            this.rbnStandardDeck.AutoSize = true;
            this.rbnStandardDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnStandardDeck.Location = new System.Drawing.Point(6, 61);
            this.rbnStandardDeck.Name = "rbnStandardDeck";
            this.rbnStandardDeck.Size = new System.Drawing.Size(189, 21);
            this.rbnStandardDeck.TabIndex = 4;
            this.rbnStandardDeck.TabStop = true;
            this.rbnStandardDeck.Text = "Standard Deck (52 cards)";
            this.rbnStandardDeck.UseVisualStyleBackColor = true;
            // 
            // lblDeck
            // 
            this.lblDeck.AutoSize = true;
            this.lblDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeck.Location = new System.Drawing.Point(6, 16);
            this.lblDeck.Name = "lblDeck";
            this.lblDeck.Size = new System.Drawing.Size(121, 17);
            this.lblDeck.TabIndex = 3;
            this.lblDeck.Text = "Choose deck type";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 237);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 32);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(476, 237);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 32);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(9, 192);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(207, 17);
            this.lblPoints.TabIndex = 8;
            this.lblPoints.Text = "Insert starting amount of points:";
            // 
            // tbxPoints
            // 
            this.tbxPoints.Location = new System.Drawing.Point(223, 192);
            this.tbxPoints.Name = "tbxPoints";
            this.tbxPoints.Size = new System.Drawing.Size(255, 20);
            this.tbxPoints.TabIndex = 6;
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 281);
            this.Controls.Add(this.tbxPoints);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbxDeck);
            this.Controls.Add(this.gbxType);
            this.Controls.Add(this.lblTitle);
            this.MaximumSize = new System.Drawing.Size(600, 320);
            this.MinimumSize = new System.Drawing.Size(600, 320);
            this.Name = "NewGameForm";
            this.Text = "Game of Poker";
            this.gbxType.ResumeLayout(false);
            this.gbxType.PerformLayout();
            this.gbxDeck.ResumeLayout(false);
            this.gbxDeck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbxType;
        private System.Windows.Forms.RadioButton rbnTexas;
        private System.Windows.Forms.RadioButton rbnStandard;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.GroupBox gbxDeck;
        private System.Windows.Forms.RadioButton rbnFrenchDeck;
        private System.Windows.Forms.RadioButton rbnStandardDeck;
        private System.Windows.Forms.Label lblDeck;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.TextBox tbxPoints;
    }
}

