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
    public partial class Form1 : Form
    {
        Microbe selectedMicrobe;
        World world;
        int curSpeed = ESConfigsDefault.DEFAULT_SPEED;
        MicrobesCollection MicrobesList = new MicrobesCollection();
        double CellW;
        double CellH;
        enum SelectMode { Single, Group };
        SelectMode selectMode = SelectMode.Single;
        ESLifeTimeChart lifeTimeChart = new ESLifeTimeChart(300);
        public static ESConfigs Configs = new ESConfigs();

        public void Reset()
        {
            PuaseMainTimer(true);
            MicrobesList.Clear();
            selectedMicrobe = null;
            world.Reset();
            //CONFIGS!!!
            //CreateMicrobes(ESConfigsDefault.INIT_MIC_NUMBER);
            CreateMicrobes(Form1.Configs.MicrobesInitNumber);
            micsCountTextBox.Text = MicrobesList.Count.ToString();
            mainPicBox.Invalidate();
            selectedMicPicBox.Invalidate();
        }

        public Form1()
        {
            InitializeComponent();

            speedTrackBar.Maximum = ESConfigsDefault.SPEED_SETTINGS.Length - 1;
            speedTrackBar.Value = ESConfigsDefault.DEFAULT_SPEED;

            mutRuleComboBox.Items.Add(MutationRule.Copy);
            mutRuleComboBox.Items.Add(MutationRule.Evalution);
            mutRuleComboBox.Items.Add(MutationRule.Random);
            mutRuleComboBox.SelectedItem = ESConfigsDefault.MUTATION_RULE;

            foodRuleComboBox.Items.Add(FoodRule.Normal);
            foodRuleComboBox.Items.Add(FoodRule.Square);
            foodRuleComboBox.SelectedItem = ESConfigsDefault.FOOD_RULE;

            speedTextBox.Text = curSpeed.ToString();
            selectedMicPicBox.Image = Properties.Resources.empty_grid_mic_arrows;

            InitSelectedMicDataGrid();
        }

        private void InitSelectedMicDataGrid()
        {
            selectedMicDataGridView.Rows.Add(9);
            selectedMicDataGridView.Rows[0].Cells[0].Value = "Energy";
            selectedMicDataGridView.Rows[1].Cells[0].Value = "X, Y";
            for (int i = 0; i < 8; i++)
                selectedMicDataGridView.Rows[i + 2].Cells[0].Value = 
                    String.Format("P[{0}] - {1}", i , Gene.traitsStrings[i]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            world = new World();
            CalculateCellSizr();
            //CONFIGS!!!
            //CreateMicrobes(ESConfigsDefault.INIT_MIC_NUMBER);
            CreateMicrobes(Form1.Configs.MicrobesInitNumber);
            mainPicBox.Image = new Bitmap(world.foodBitmap, mainPicBox.Size);
            mainTimer.Interval = ESConfigsDefault.SPEED_SETTINGS[curSpeed];
            micsCountTextBox.Text = MicrobesList.Count.ToString();
        }

        void CalculateCellSizr()
        {
            CellW = mainPicBox.Size.Width / (double)ESConfigsDefault.CELLS_X;
            CellH = mainPicBox.Size.Height / (double)ESConfigsDefault.CELLS_Y;
        }

        void CreateMicrobes(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Microbe m = new Microbe(ESConfigsDefault.Rnd.Next(ESConfigsDefault.CELLS_X),
                                          ESConfigsDefault.Rnd.Next(ESConfigsDefault.CELLS_Y),
                                          ESConfigsDefault.Rnd.Next(8),
                                          ESConfigsDefault.Rnd.Next(180, 200));
                MicrobesList.Add(m);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Microbe m = MicrobesList.First;
            while (m != null)
            {
                Microbe n = m.Next;
                
                if (world.EatFood(m.X, m.Y))                //If can eat food in current position
                {
                    if (m.EatFood())                        //If able to reproduce
                    {
                        Microbe newMic = m.Reproduce();     //Create new microbe
                        MicrobesList.Add(newMic);           //Add new microbe to the list
                    }
                }
                m.Move();                                   //Move microbe
                if (m.IsDead())                             //If microbe has stareved to death
                {                                           //remove it from the list
                    MicrobesList.Remove(m);
                }

                m = n;
            }

            world.AddFood();                                //Add food to the world

            mainPicBox.Invalidate();
            micsCountTextBox.Text = MicrobesList.Count.ToString();
            DisplaySelectedMicData();
        }

        private void mainPicBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(world.foodBitmap, 0, 0, mainPicBox.Size.Width, mainPicBox.Size.Height);
            CalculateCellSizr();
            int MicW = (int)(4 * CellW);
            int MicH = (int)(4 * CellH);

            Microbe m = MicrobesList.First;
            while (m != null)
            {
                Microbe n = m.Next;
                SolidBrush br = m.IsMarked ? ESConfigsDefault.MIC_BRUSH_MARKED : ESConfigsDefault.MIC_BRUSH;
                g.FillRectangle(br,
                        (int)((m.X - 2) * CellW),
                        (int)((m.Y - 2) * CellH),
                        MicW, MicH);
                m = n;
            }
            if (selectedMicrobe != null && selectedMicrobe.IsAlive)
                g.FillRectangle(ESConfigsDefault.MIC_BRUSH_MARKED,
                            (int)((selectedMicrobe.X - 2) * CellW),
                            (int)((selectedMicrobe.Y - 2) * CellH),
                            MicW, MicH);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            PuaseMainTimer();
        }

        void PuaseMainTimer(bool pause)
        {
            if (pause)
            {
                mainTimer.Stop();
                startBtn.Text = "Play";
            }
            else
            {
                mainTimer.Start();
                startBtn.Text = "Pause";
            }
        }

        void PuaseMainTimer()
        {
            PuaseMainTimer(mainTimer.Enabled);
        }

        void SlowDown(bool mode)
        {
            if (mode)
            {
                curSpeed--;
                if (curSpeed < 0)
                    curSpeed = 0;
            }
            else
            {
                curSpeed++;
                if (curSpeed >= ESConfigsDefault.SPEED_SETTINGS.Length)
                    curSpeed = ESConfigsDefault.SPEED_SETTINGS.Length - 1;
            }
            mainTimer.Interval = ESConfigsDefault.SPEED_SETTINGS[curSpeed];
            speedTrackBar.Value = curSpeed;
            if (!mainTimer.Enabled)
            {
                PuaseMainTimer(false);
            }
            speedTextBox.Text = curSpeed.ToString();
        }

        private void ffBtn_Click(object sender, EventArgs e)
        {
            SlowDown(false);
        }

        private void sdBtn_Click(object sender, EventArgs e)
        {
            SlowDown(true);
        }

        private void speedTrackBar_Scroll(object sender, EventArgs e)
        {
            curSpeed = speedTrackBar.Value;
            mainTimer.Interval = ESConfigsDefault.SPEED_SETTINGS[curSpeed];
            if (!mainTimer.Enabled)
            {
                PuaseMainTimer(false);
            }
            speedTextBox.Text = curSpeed.ToString();
        }

        private void mutRuleComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ESConfigsDefault.MUTATION_RULE = (MutationRule)mutRuleComboBox.SelectedItem;
        }

        private void foodRuleComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ESConfigsDefault.FOOD_RULE = (FoodRule)foodRuleComboBox.SelectedItem;
        }

        private void mainPicBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && selectMode == SelectMode.Single)
            {
                selectedMicPicBox.Image = Properties.Resources.empty_grid_mic_arrows;
                if (selectedMicrobe != null)
                    selectedMicrobe.IsMarked = false;
                double cx = e.X / CellW;
                double cy = e.Y / CellH;
                double len = 0.0;
                double minLen = Double.MaxValue;
                Microbe m = MicrobesList.First;
                while (m != null)
                {
                    Microbe n = m.Next;
                    len = Math.Sqrt(Math.Pow(cx - m.X, 2) + Math.Pow(cy - m.Y, 2));
                    if (minLen > len)
                    {
                        minLen = len;
                        selectedMicrobe = m;
                    }
                    m = n;
                }
                if (selectedMicrobe != null)
                {
                    selectedMicrobe.IsMarked = true;
                    mainPicBox.Invalidate();
                    DisplaySelectedMicData();
                    selectedMicPicBox.Invalidate();
                }
            }
        }

        Point groupMStartPnt = new Point(0, 0);
        bool groupDrag = false;
        private void mainPicBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && selectMode == SelectMode.Group)
            {
                groupMStartPnt.X = e.X;
                groupMStartPnt.Y = e.Y;
                groupDrag = true;
            }
        }
        private void mainPicBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && selectMode == SelectMode.Group && groupDrag)
            {
                Point minPt = new Point((int)(Math.Min(groupMStartPnt.X, e.X) / CellW), 
                    (int)(Math.Min(groupMStartPnt.Y, e.Y) / CellH));
                Point maxPt = new Point((int)(Math.Max(groupMStartPnt.X, e.X) / CellW),
                    (int)(Math.Max(groupMStartPnt.Y, e.Y) / CellH));
                ESDiagnostics diagn = new ESDiagnostics();

                Microbe m = MicrobesList.First;
                while (m != null)
                {
                    Microbe n = m.Next;
                    if (m.X > minPt.X && m.Y > minPt.Y &&
                        m.X < maxPt.X && m.Y < maxPt.Y)
                    {
                        diagn.Add(m);
                    }
                    m = n;
                }
                if (diagn.Count > 0)
                {
                    MicStatsForm msf = new MicStatsForm(diagn.AvgStats(), diagn.Count);
                    msf.Show();
                }
            }
            groupDrag = false;
        }

        
        private void DisplaySelectedMicData()
        {
            if (selectedMicrobe != null)
            {
                selectedMicDataGridView.Rows[0].Cells[1].Value = selectedMicrobe.Energy;
                selectedMicDataGridView.Rows[1].Cells[1].Value =
                    String.Format("{0}, {1}", selectedMicrobe.X, selectedMicrobe.Y);
                for (int i = 0; i < 8; i++)
                    selectedMicDataGridView.Rows[i + 2].Cells[1].Value =
                        String.Format("{0:0.########}", selectedMicrobe.Genes.Traits[i]);
                selectedMicPicBox.Invalidate();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                PuaseMainTimer();
            }
        }

        private void selectedMicPicBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            ESRenderer.DrawMicrobeStats(g, selectedMicrobe);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void singleMicrobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            singleMicrobeToolStripMenuItem.CheckState = CheckState.Checked;
            goupeToolStripMenuItem.CheckState = CheckState.Unchecked;
            selectMode = SelectMode.Single;
        }

        private void goupeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            singleMicrobeToolStripMenuItem.CheckState = CheckState.Unchecked;
            goupeToolStripMenuItem.CheckState = CheckState.Checked;
            selectMode = SelectMode.Group;
            if (selectedMicrobe != null)
            {
                selectedMicrobe.IsMarked = false;
                selectedMicrobe = null;
            }
            selectedMicPicBox.Invalidate();
        }

        private void diagnoseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ESDiagnostics diagn = new ESDiagnostics();

            Microbe m = MicrobesList.First;
            while (m != null)
            {
                Microbe n = m.Next;
                diagn.Add(m);
                m = n;
            }
            if (diagn.Count > 0)
            {
                MicStatsForm msf = new MicStatsForm(diagn.AvgStats(), diagn.Count);
                msf.Show();
            }
            else
            {
                MessageBox.Show("0 Microbes.", "Diagnostics", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chartTimer_Tick(object sender, EventArgs e)
        {
            if(mainTimer.Enabled)
                lifeTimeChart.Add(MicrobesList.Count);
        }

        
        private void microbesChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ESLifeChartForm ltcForm = new ESLifeChartForm(lifeTimeChart);
            ltcForm.Show();
        }

        private void changeSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigsForm cf = new ConfigsForm();
            cf.Show();
        }

    }
}
