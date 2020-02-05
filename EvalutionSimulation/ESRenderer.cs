using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EvalutionSimulation
{
    class ESRenderer
    {
        static Pen greenPen5 = new Pen(Color.Green, 5);
        static Pen redPen5 = new Pen(Color.Red, 5);
        static Pen blackPen1 = new Pen(Color.Black);
        static Pen greenPen1 = new Pen(Color.Green);
        static Pen bluePen1 = new Pen(Color.Blue);
        static SolidBrush clearBrush = new SolidBrush(Color.White);
        static Point middelPoint = new Point(58, 58);
        static Point[] gridPoints = { new Point(58, 0), new Point(116, 0), new Point(116, 58),  
                                    new Point(116, 116), new Point(58, 116), new Point(0, 116),
                                    new Point(0, 58), new Point(0, 0)};

        public static void DrawMicrobeStats(Graphics g, Microbe m)
        {
            if (m != null)
            {
                //Draw traits
                for (int i = 0; i < m.Genes.Traits.Length; i++)
                {
                    SolidBrush sBrush = new SolidBrush(m.Genes.GetTraitColor(i));
                    int h = (int)(50 * m.Genes.Traits[i]);
                    int minRec = m.Genes.Traits[i] > 0.00000001 ? 4 : 0;
                    g.FillRectangle(sBrush,
                        gridPoints[i].X + 11, gridPoints[i].Y + 57 - h - minRec,
                        36, h + minRec);
                }
                if (m.IsAlive)
                {
                    //Draw energy bar
                    SolidBrush brush = new SolidBrush(m.GetEnergyColor());
                    //CONFIGS!!!
                    //int w = (int)(50 * m.Energy / ESConfigsDefault.MAX_ENERGY);
                    int w = (int)(50 * m.Energy / Form1.Configs.MaxEnergy);
                    g.FillRectangle(brush, middelPoint.X + 4, middelPoint.Y + 14, w, 30);
                    //Draw energy bar frame
                    g.DrawRectangle(blackPen1, middelPoint.X + 4, middelPoint.Y + 14, 50, 30);
                    //Draw reproduse energy line
                    int lineX = middelPoint.X;
                    //CONFIGS!!!
                    //lineX += (int)(50 * ESConfigsDefault.REPRODUCE_ENERGY / ESConfigsDefault.MAX_ENERGY) + 4;
                    lineX += (int)(50 * Form1.Configs.ReproduceEnergy / Form1.Configs.MaxEnergy) + 4;
                    g.DrawLine(bluePen1, lineX, middelPoint.Y + 12, lineX, middelPoint.Y + 46);
                }
                else
                {
                    //Draw red cross
                    g.DrawLine(redPen5, middelPoint.X + 13, middelPoint.Y + 13,
                        middelPoint.X + 43, middelPoint.Y + 43);
                    g.DrawLine(redPen5, middelPoint.X + 43, middelPoint.Y + 13,
                        middelPoint.X + 13, middelPoint.Y + 43);
                }
            }
        }
    }
}
