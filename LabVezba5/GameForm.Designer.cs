
namespace LabVezba5
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.lblStartPoints = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tbxBetAmount = new System.Windows.Forms.TextBox();
            this.lblBetAmount = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbxFifth = new System.Windows.Forms.PictureBox();
            this.pbxFourth = new System.Windows.Forms.PictureBox();
            this.pbxThird = new System.Windows.Forms.PictureBox();
            this.pbxSecond = new System.Windows.Forms.PictureBox();
            this.pbxFirst = new System.Windows.Forms.PictureBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblBetPoints = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblPointsWon = new System.Windows.Forms.Label();
            this.lblWonPoints = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFifth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFourth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxThird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFirst)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStartPoints
            // 
            this.lblStartPoints.AutoSize = true;
            this.lblStartPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartPoints.Location = new System.Drawing.Point(12, 57);
            this.lblStartPoints.Name = "lblStartPoints";
            this.lblStartPoints.Size = new System.Drawing.Size(103, 17);
            this.lblStartPoints.TabIndex = 0;
            this.lblStartPoints.Text = "Starting points:";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(111, 57);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(46, 17);
            this.lblPoints.TabIndex = 1;
            this.lblPoints.Text = "points";
            // 
            // btnDeal
            // 
            this.btnDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeal.Location = new System.Drawing.Point(459, 87);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(113, 31);
            this.btnDeal.TabIndex = 2;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(459, 124);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(113, 31);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(459, 214);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(113, 31);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbxBetAmount
            // 
            this.tbxBetAmount.Location = new System.Drawing.Point(140, 225);
            this.tbxBetAmount.Name = "tbxBetAmount";
            this.tbxBetAmount.Size = new System.Drawing.Size(291, 20);
            this.tbxBetAmount.TabIndex = 13;
            this.tbxBetAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxBetAmount_KeyPress);
            // 
            // lblBetAmount
            // 
            this.lblBetAmount.AutoSize = true;
            this.lblBetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetAmount.Location = new System.Drawing.Point(12, 228);
            this.lblBetAmount.Name = "lblBetAmount";
            this.lblBetAmount.Size = new System.Drawing.Size(122, 17);
            this.lblBetAmount.TabIndex = 14;
            this.lblBetAmount.Text = "Insert bet amount:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(10, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 26);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Game of Poker";
            // 
            // pbxFifth
            // 
            this.pbxFifth.Location = new System.Drawing.Point(366, 92);
            this.pbxFifth.Name = "pbxFifth";
            this.pbxFifth.Size = new System.Drawing.Size(65, 100);
            this.pbxFifth.TabIndex = 12;
            this.pbxFifth.TabStop = false;
            this.pbxFifth.Click += new System.EventHandler(this.pbxFifth_Click);
            // 
            // pbxFourth
            // 
            this.pbxFourth.Location = new System.Drawing.Point(281, 92);
            this.pbxFourth.Name = "pbxFourth";
            this.pbxFourth.Size = new System.Drawing.Size(65, 100);
            this.pbxFourth.TabIndex = 11;
            this.pbxFourth.TabStop = false;
            this.pbxFourth.Click += new System.EventHandler(this.pbxFourth_Click);
            // 
            // pbxThird
            // 
            this.pbxThird.Location = new System.Drawing.Point(192, 92);
            this.pbxThird.Name = "pbxThird";
            this.pbxThird.Size = new System.Drawing.Size(65, 100);
            this.pbxThird.TabIndex = 10;
            this.pbxThird.TabStop = false;
            this.pbxThird.Click += new System.EventHandler(this.pbxThird_Click);
            // 
            // pbxSecond
            // 
            this.pbxSecond.Location = new System.Drawing.Point(104, 92);
            this.pbxSecond.Name = "pbxSecond";
            this.pbxSecond.Size = new System.Drawing.Size(65, 100);
            this.pbxSecond.TabIndex = 9;
            this.pbxSecond.TabStop = false;
            this.pbxSecond.Click += new System.EventHandler(this.pbxSecond_Click);
            // 
            // pbxFirst
            // 
            this.pbxFirst.Location = new System.Drawing.Point(15, 92);
            this.pbxFirst.Name = "pbxFirst";
            this.pbxFirst.Size = new System.Drawing.Size(65, 100);
            this.pbxFirst.TabIndex = 8;
            this.pbxFirst.TabStop = false;
            this.pbxFirst.Click += new System.EventHandler(this.pbxFirst_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(175, 12);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(38, 13);
            this.lblText.TabIndex = 16;
            this.lblText.Text = "lblText";
            // 
            // lblBetPoints
            // 
            this.lblBetPoints.AutoSize = true;
            this.lblBetPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetPoints.Location = new System.Drawing.Point(300, 38);
            this.lblBetPoints.Name = "lblBetPoints";
            this.lblBetPoints.Size = new System.Drawing.Size(46, 17);
            this.lblBetPoints.TabIndex = 18;
            this.lblBetPoints.Text = "points";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.Location = new System.Drawing.Point(175, 38);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(127, 17);
            this.lblBet.TabIndex = 17;
            this.lblBet.Text = "Taken bet amount:";
            // 
            // lblPointsWon
            // 
            this.lblPointsWon.AutoSize = true;
            this.lblPointsWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsWon.Location = new System.Drawing.Point(175, 64);
            this.lblPointsWon.Name = "lblPointsWon";
            this.lblPointsWon.Size = new System.Drawing.Size(197, 17);
            this.lblPointsWon.TabIndex = 19;
            this.lblPointsWon.Text = "Points won from current hand:";
            // 
            // lblWonPoints
            // 
            this.lblWonPoints.AutoSize = true;
            this.lblWonPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWonPoints.Location = new System.Drawing.Point(372, 64);
            this.lblWonPoints.Name = "lblWonPoints";
            this.lblWonPoints.Size = new System.Drawing.Size(0, 17);
            this.lblWonPoints.TabIndex = 20;
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.Location = new System.Drawing.Point(459, 161);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(113, 31);
            this.btnReplace.TabIndex = 21;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.lblWonPoints);
            this.Controls.Add(this.lblPointsWon);
            this.Controls.Add(this.lblBetPoints);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbxBetAmount);
            this.Controls.Add(this.lblBetAmount);
            this.Controls.Add(this.pbxFifth);
            this.Controls.Add(this.pbxFourth);
            this.Controls.Add(this.pbxThird);
            this.Controls.Add(this.pbxSecond);
            this.Controls.Add(this.pbxFirst);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblStartPoints);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 300);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Poker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFifth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFourth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxThird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFirst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartPoints;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pbxFirst;
        private System.Windows.Forms.PictureBox pbxSecond;
        private System.Windows.Forms.PictureBox pbxThird;
        private System.Windows.Forms.PictureBox pbxFourth;
        private System.Windows.Forms.PictureBox pbxFifth;
        private System.Windows.Forms.TextBox tbxBetAmount;
        private System.Windows.Forms.Label lblBetAmount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblBetPoints;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Label lblPointsWon;
        private System.Windows.Forms.Label lblWonPoints;
        private System.Windows.Forms.Button btnReplace;
    }
}