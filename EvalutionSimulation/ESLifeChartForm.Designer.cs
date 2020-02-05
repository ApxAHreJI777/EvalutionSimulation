namespace EvalutionSimulation
{
    partial class ESLifeChartForm
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
            this.chartTimer = new System.Windows.Forms.Timer(this.components);
            this.chartPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTimer
            // 
            this.chartTimer.Interval = 20;
            this.chartTimer.Tick += new System.EventHandler(this.chartTimer_Tick);
            // 
            // chartPictureBox
            // 
            this.chartPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPictureBox.Location = new System.Drawing.Point(0, 0);
            this.chartPictureBox.Name = "chartPictureBox";
            this.chartPictureBox.Size = new System.Drawing.Size(411, 283);
            this.chartPictureBox.TabIndex = 0;
            this.chartPictureBox.TabStop = false;
            this.chartPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.chartPictureBox_Paint);
            // 
            // ESLifeChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 283);
            this.Controls.Add(this.chartPictureBox);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "ESLifeChartForm";
            this.Text = "Evalution Simulation Diagram";
            ((System.ComponentModel.ISupportInitialize)(this.chartPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox chartPictureBox;
        private System.Windows.Forms.Timer chartTimer;
    }
}