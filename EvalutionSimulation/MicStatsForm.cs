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
    public partial class MicStatsForm : Form
    {
        Microbe microbe;
        public MicStatsForm(Microbe m, int count)
        {
            InitializeComponent();
            label1.Text = String.Format("Average traits of {0} microbes", count);
            selectedMicPicBox.Image = Properties.Resources.empty_grid_mic_arrows;
            microbe = m;
        }

        private void selectedMicPicBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            ESRenderer.DrawMicrobeStats(g, microbe);
        }
    }
}
