using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EvalutionSimulation
{
    public class Microbe
    {

        public static Point[] Movments = 
        {
            new Point(0, -1),
            new Point(1, -1),
            new Point(1, 0),
            new Point(1, 1),
            new Point(0, 1),
            new Point(-1, 1),
            new Point(-1, 0),
            new Point(-1, -1)
        };
        public static byte[] TurnCost = { 0, 1, 2, 4, 8, 4, 2, 1 };

        private int x = 0;
        private int y = 0;
        private int direction = 0;
        private int energy = 0;

        public bool IsMarked = false;
        public bool IsAlive = true;
        public Microbe Next;
        public Microbe Prev;
        public int X 
        { 
            get { return x; }
            set 
            {
                if (value < 0)
                    x = ESConfigsDefault.CELLS_X - 1;
                else if (value >= ESConfigsDefault.CELLS_X)
                    x = 0;
                else
                    x = value;
            }
        }
        public int Y
        {
            get { return y; }
            set
            {
                if (value < 0)
                    y = ESConfigsDefault.CELLS_Y - 1;
                else if (value >= ESConfigsDefault.CELLS_Y)
                    y = 0;
                else
                    y = value;
            }
        }
        public int Dir 
        { 
            get { return direction; }
            set { direction = value % 8; }
        }

        public int Energy
        {
            get { return energy; }
            set 
            {
                //CONFIGS!!!
                //if (value < 0)
                //    energy = 0;
                //else if (value > ESConfigsDefault.MAX_ENERGY)
                //    energy = ESConfigsDefault.MAX_ENERGY;
                //else
                //    energy = value;
                if (value < 0)
                    energy = 0;
                else if (value > Form1.Configs.MaxEnergy)
                    energy = Form1.Configs.MaxEnergy;
                else
                    energy = value; 
            }
        }

        public Gene Genes;

        public Microbe(int _x, int _y, int _dir, int _energy)
        {
            X = _x;
            Y = _y;
            Dir = _dir;
            Energy = _energy;
            Genes = new Gene();
        }

        public Microbe(int _x, int _y, int _dir, int _energy, Gene _genes)
        {
            X = _x;
            Y = _y;
            Dir = _dir;
            Energy = _energy;
            Genes = _genes;
        }

        public Microbe(Microbe m)
        {
            X = m.X;
            Y = m.Y;
            Dir = ESConfigsDefault.Rnd.Next(8);
            Energy = m.Energy;
            Genes = new Gene(m.Genes);
            Genes.Mutate();
        }

        public bool EatFood()
        {
            //CONFIGS!!!
            //Energy += ESConfigsDefault.ENERGY_PER_FOOD;
            //return Energy >= ESConfigsDefault.REPRODUCE_ENERGY;
            Energy += Form1.Configs.EnergyPerFood;
            return Energy >= Form1.Configs.ReproduceEnergy;
        }

        public Microbe Reproduce()
        {
            Energy = Energy / 2;
            return new Microbe(this);
        }

        public void Move()
        {
            //get next action according to the genes
            int action = Genes.GetNextAction();
            Energy -= TurnCost[action];
            
            //Move accordint to new direction
            Dir = (Dir + action) % 8;
            X += Movments[Dir].X;
            Y += Movments[Dir].Y;
            //CONFIGS!!!
            //Energy -= ESConfigsDefault.ENERGY_PER_MOVE;
            Energy -= Form1.Configs.EnergyPerMove;
        }

        public bool IsDead()
        {
            return Energy <= 0;
        }

        public Color GetEnergyColor()
        {
            int red = 255;
            int green = 255;
            //CONFIGS!!!
            //double x = Energy < ESConfigsDefault.REPRODUCE_ENERGY ?
            //    Energy - ESConfigsDefault.REPRODUCE_ENERGY / 2 : 
            //    ESConfigsDefault.REPRODUCE_ENERGY / 2;

            //if (x > 0)
            //    red = 255 - (int)(510 * Math.Abs(x) / ESConfigsDefault.REPRODUCE_ENERGY);
            //else if (x < 0)
            //    green = 255 - (int)(510 * Math.Abs(x) / ESConfigsDefault.REPRODUCE_ENERGY);

            double x = Energy < Form1.Configs.ReproduceEnergy ?
                Energy - Form1.Configs.ReproduceEnergy / 2 :
                Form1.Configs.ReproduceEnergy / 2;

            if (x > 0)
                red = 255 - (int)(510 * Math.Abs(x) / Form1.Configs.ReproduceEnergy);
            else if (x < 0)
                green = 255 - (int)(510 * Math.Abs(x) / Form1.Configs.ReproduceEnergy);

            return Color.FromArgb(200, red, 0, green);
        }


    }
}
