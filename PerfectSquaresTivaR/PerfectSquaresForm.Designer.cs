namespace PerfectSquaresTivaR
{
    partial class frmPerfectSquares
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
            this.nudEndValue = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstSquares = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndValue)).BeginInit();
            this.SuspendLayout();
            // 
            // nudEndValue
            // 
            this.nudEndValue.Location = new System.Drawing.Point(111, 68);
            this.nudEndValue.Name = "nudEndValue";
            this.nudEndValue.Size = new System.Drawing.Size(120, 20);
            this.nudEndValue.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(132, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstSquares
            // 
            this.lstSquares.FormattingEnabled = true;
            this.lstSquares.Location = new System.Drawing.Point(111, 116);
            this.lstSquares.Name = "lstSquares";
            this.lstSquares.Size = new System.Drawing.Size(120, 95);
            this.lstSquares.TabIndex = 2;
            // 
            // frmPerfectSquares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 250);
            this.Controls.Add(this.lstSquares);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nudEndValue);
            this.Name = "frmPerfectSquares";
            this.Text = "Perfect Squares By Tiva Rait";
            ((System.ComponentModel.ISupportInitialize)(this.nudEndValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudEndValue;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstSquares;
    }
}

