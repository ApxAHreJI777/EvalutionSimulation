namespace EvalutionSimulation
{
    partial class ConfigsForm
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
            this.configsPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // configsPropertyGrid
            // 
            this.configsPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configsPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.configsPropertyGrid.Name = "configsPropertyGrid";
            this.configsPropertyGrid.Size = new System.Drawing.Size(291, 346);
            this.configsPropertyGrid.TabIndex = 0;
            // 
            // ConfigsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 346);
            this.Controls.Add(this.configsPropertyGrid);
            this.Name = "ConfigsForm";
            this.Text = "ConfigsForm";
            this.Load += new System.EventHandler(this.ConfigsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid configsPropertyGrid;
    }
}