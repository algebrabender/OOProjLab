
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.tbxPoints = new System.Windows.Forms.TextBox();
            this.tbxBetAmount = new System.Windows.Forms.TextBox();
            this.lblBetAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(60, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Game of Poker";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(39, 202);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 32);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(147, 202);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(36, 55);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(207, 17);
            this.lblPoints.TabIndex = 8;
            this.lblPoints.Text = "Insert starting amount of points:";
            // 
            // tbxPoints
            // 
            this.tbxPoints.Location = new System.Drawing.Point(39, 93);
            this.tbxPoints.Name = "tbxPoints";
            this.tbxPoints.Size = new System.Drawing.Size(204, 20);
            this.tbxPoints.TabIndex = 1;
            this.tbxPoints.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPoints_KeyPress);
            // 
            // tbxBetAmount
            // 
            this.tbxBetAmount.Location = new System.Drawing.Point(39, 157);
            this.tbxBetAmount.Name = "tbxBetAmount";
            this.tbxBetAmount.Size = new System.Drawing.Size(204, 20);
            this.tbxBetAmount.TabIndex = 2;
            this.tbxBetAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxBetAmount_KeyPress);
            // 
            // lblBetAmount
            // 
            this.lblBetAmount.AutoSize = true;
            this.lblBetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetAmount.Location = new System.Drawing.Point(36, 126);
            this.lblBetAmount.Name = "lblBetAmount";
            this.lblBetAmount.Size = new System.Drawing.Size(122, 17);
            this.lblBetAmount.TabIndex = 16;
            this.lblBetAmount.Text = "Insert bet amount:";
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbxBetAmount);
            this.Controls.Add(this.lblBetAmount);
            this.Controls.Add(this.tbxPoints);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitle);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "NewGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Poker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.TextBox tbxPoints;
        private System.Windows.Forms.TextBox tbxBetAmount;
        private System.Windows.Forms.Label lblBetAmount;
    }
}

