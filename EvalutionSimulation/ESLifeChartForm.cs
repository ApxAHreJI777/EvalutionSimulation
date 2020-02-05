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
    public partial class ESLifeChartForm : Form
    {
        ESLifeTimeChart chart;
        int scale = 10;
        int xPed = 40;
        int yPed = 40;
        int minS = 0;
        int maxS = 10;

        Pen penChart = new Pen(Color.Black, 1);
        Pen penLine = new Pen(Color.Green, 1);
        Pen penCurLine = new Pen(Color.Red, 1);
        Color bgChartColor = Color.White;
        SolidBrush textBrush = new SolidBrush(Color.Black);
        SolidBrush curLvlTextBrush = new SolidBrush(Color.Red);
        int textFontSize = 10;
        string textFontFamilyName = "Arial";
        Font textFont;

        public ESLifeChartForm(ESLifeTimeChart ltc)
        {
            InitializeComponent();
            textFont = new Font(textFontFamilyName, textFontSize);
            chart = ltc;
            chartTimer.Start();
        }

        private void chartTimer_Tick(object sender, EventArgs e)
        {
            scale = 1;
            minS = Int32.MaxValue;
            maxS = 0;
            foreach (int v in chart.que)
            {
                if (maxS < v) maxS = v;
                if (minS > v) minS = v;
            }
            if (chart.que.Count < chart.MaxLength)
            {
                scale = maxS;
                minS = 0;
            }
            else
            {
                scale = maxS - minS;
            }
            if (scale < 10) scale = 10;
            chartPictureBox.Invalidate();
        }

        private void chartPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(bgChartColor);
            //vert line
            g.DrawLine(penChart, xPed, yPed / 2, xPed, chartPictureBox.Size.Height - yPed / 2);
            //Arrow
            g.DrawLine(penChart, xPed, yPed / 2, xPed - 3, yPed / 2 + 5);
            g.DrawLine(penChart, xPed, yPed / 2, xPed + 3, yPed / 2 + 5);
            //hor line
            int hLineX = chartPictureBox.Size.Width - xPed / 2;
            int hLineY = chartPictureBox.Size.Height - yPed + 1;
            g.DrawLine(penChart, xPed / 2, hLineY, hLineX, hLineY);
            //Arrow
            g.DrawLine(penChart, hLineX, hLineY, hLineX - 5, hLineY - 3);
            g.DrawLine(penChart, hLineX, hLineY, hLineX - 5, hLineY + 3);

            int xLen = chartPictureBox.Size.Width - xPed * 2;
            int yLen = chartPictureBox.Size.Height - yPed * 2;
            float xStemp = xLen / (float)chart.MaxLength;
            float yStemp = scale == 0 ? 1 : yLen / (float)scale;
            int pv = 0;
            int t = 0;
            foreach (int v in chart.que)
            {
                if (t != 0)
                {
                    g.DrawLine(penLine,
                        (t - 1) * xStemp + xPed,
                        yLen - ((pv - minS) * yStemp) + yPed,
                        t * xStemp + xPed,
                        yLen - ((v - minS) * yStemp) + yPed);
                }
                pv = v;
                t++;
            }

            g.DrawLine(penChart, xPed - 4, yPed, xPed + 4, yPed);
            //Write Max Value
            SizeF textSize = g.MeasureString(maxS.ToString(), textFont);
            g.DrawString(maxS.ToString(), textFont, textBrush,
                xPed - textSize.Width - 2,
                yPed - textSize.Height);
            //Write Min Value
            textSize = g.MeasureString(minS.ToString(), textFont);
            g.DrawString(minS.ToString(), textFont, textBrush,
                xPed - textSize.Width - 2,
                chartPictureBox.Size.Height - yPed - textSize.Height);

            //Draw current level line
            float curLvlY = yLen - ((pv - minS) * yStemp) + yPed;
            float curLvlX = chartPictureBox.Size.Width - xPed;
            g.DrawLine(penCurLine, xPed - 4, curLvlY,
                        curLvlX, curLvlY);

            textSize = g.MeasureString(pv.ToString(), textFont);
            g.DrawString(pv.ToString(), textFont, curLvlTextBrush,
                curLvlX - textSize.Width - 2,
                curLvlY - textSize.Height);
        }
    }
}
