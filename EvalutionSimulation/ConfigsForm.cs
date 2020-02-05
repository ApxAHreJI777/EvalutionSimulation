using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EvalutionSimulation
{
    public partial class ConfigsForm : Form
    {
        ContextMenuStrip ctxMenuStrip = new ContextMenuStrip();
        ToolStripMenuItem resetToolStripMenuItem = new ToolStripMenuItem();
        public ConfigsForm()
        {
            InitializeComponent();
        }

        private void ConfigsForm_Load(object sender, EventArgs e)
        {
            ctxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            resetToolStripMenuItem});
            ctxMenuStrip.Size = new System.Drawing.Size(153, 48);

            resetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            resetToolStripMenuItem.Text = "Reset";
            resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);

            configsPropertyGrid.ContextMenuStrip = ctxMenuStrip;
            configsPropertyGrid.SelectedObject = Form1.Configs;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configsPropertyGrid.ResetSelectedProperty();
        }
    }
}
