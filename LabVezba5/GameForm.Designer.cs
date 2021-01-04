
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
            this.lblStartPoints = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSeeCC = new System.Windows.Forms.Button();
            this.cbxReplace = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStartPoints
            // 
            this.lblStartPoints.AutoSize = true;
            this.lblStartPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartPoints.Location = new System.Drawing.Point(12, 9);
            this.lblStartPoints.Name = "lblStartPoints";
            this.lblStartPoints.Size = new System.Drawing.Size(103, 17);
            this.lblStartPoints.TabIndex = 0;
            this.lblStartPoints.Text = "Starting points:";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(111, 9);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(46, 17);
            this.lblPoints.TabIndex = 1;
            this.lblPoints.Text = "points";
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Location = new System.Drawing.Point(645, 12);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(113, 31);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.Location = new System.Drawing.Point(645, 119);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(113, 31);
            this.btnReplace.TabIndex = 3;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(645, 165);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(113, 31);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnSeeCC
            // 
            this.btnSeeCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeCC.Location = new System.Drawing.Point(645, 212);
            this.btnSeeCC.Name = "btnSeeCC";
            this.btnSeeCC.Size = new System.Drawing.Size(113, 31);
            this.btnSeeCC.TabIndex = 5;
            this.btnSeeCC.Text = "See CC";
            this.btnSeeCC.UseVisualStyleBackColor = true;
            // 
            // cbxReplace
            // 
            this.cbxReplace.DisplayMember = "0, 1, 2, 3";
            this.cbxReplace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxReplace.FormattingEnabled = true;
            this.cbxReplace.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbxReplace.Location = new System.Drawing.Point(645, 92);
            this.cbxReplace.Name = "cbxReplace";
            this.cbxReplace.Size = new System.Drawing.Size(113, 21);
            this.cbxReplace.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(642, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cards to replace:";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxReplace);
            this.Controls.Add(this.btnSeeCC);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblStartPoints);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartPoints;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSeeCC;
        private System.Windows.Forms.ComboBox cbxReplace;
        private System.Windows.Forms.Label label1;
    }
}