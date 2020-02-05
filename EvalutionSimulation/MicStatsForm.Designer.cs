namespace EvalutionSimulation
{
    partial class MicStatsForm
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
            this.selectedMicPicBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selectedMicPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedMicPicBox
            // 
            this.selectedMicPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedMicPicBox.Location = new System.Drawing.Point(12, 29);
            this.selectedMicPicBox.Name = "selectedMicPicBox";
            this.selectedMicPicBox.Size = new System.Drawing.Size(174, 174);
            this.selectedMicPicBox.TabIndex = 16;
            this.selectedMicPicBox.TabStop = false;
            this.selectedMicPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.selectedMicPicBox_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // MicStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedMicPicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MicStatsForm";
            this.Text = "Average Traits";
            ((System.ComponentModel.ISupportInitialize)(this.selectedMicPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox selectedMicPicBox;
        private System.Windows.Forms.Label label1;
    }
}