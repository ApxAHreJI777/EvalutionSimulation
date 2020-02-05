using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EvalutionSimulation
{
    public class Gene
    {
        public static string[] traitsStrings = {"Forward", "Light Right", "Right", "Hard Right",
                                               "Back", "Hard Left", "Left", "Light Left"};
        public const int traitsNum = 8;
        public double[] Traits = new double[traitsNum];

        public Gene()
        {
            Traits = CreateTraits();
        }

        public Gene(double[] _tr)
        {
            if (_tr.Length == traitsNum)
                _tr.CopyTo(Traits, 0);
            else
                throw new ArgumentException("Array length must be equal to number of traits");
        }

        public Gene(Gene g)
        {
            g.Traits.CopyTo(Traits, 0);
        }

        public static double[] CreateTraits()
        {
            double[] newTraits = new double[traitsNum];
            double sum = 0.0;
            // Generate random traits
            for (int i = 0; i < traitsNum; i++)
            {
                double nextRnd = ESConfigsDefault.Rnd.NextDouble();
                newTraits[i] = nextRnd;
                sum += nextRnd;
            }
            //Normalaiz traits, sum = 1
            for (int i = 0; i < traitsNum; i++)
            {
                newTraits[i] = newTraits[i] / sum;
            }
            return newTraits;
        }

        public void MutateTraits()
        {
            //Mutate random trait
            int rndTrait = ESConfigsDefault.Rnd.Next(traitsNum);
            double newTrait = Traits[rndTrait] + ESConfigsDefault.Rnd.NextDouble() - 0.5;
            Traits[rndTrait] = newTrait < 0 ? 0 : newTrait;
            //Normalaiz traits, sum = 1
            double sum = 0.0;
            for (int i = 0; i < traitsNum; i++)
            {
                sum += Traits[i];
            }
            for (int i = 0; i < traitsNum; i++)
            {
                Traits[i] = Traits[i] / sum;
            }
        }

        public void Mutate()
        {
            if (ESConfigsDefault.MUTATION_RULE == MutationRule.Copy)
            {
                return;
            }
            else if (ESConfigsDefault.MUTATION_RULE == MutationRule.Evalution)
            {
                MutateTraits();
                return;
            }
            else if (ESConfigsDefault.MUTATION_RULE == MutationRule.Random)
            {
                Traits = CreateTraits();
                return;
            }
        }

        public int GetNextAction()
        {
            int action = 0;
            double rnd = ESConfigsDefault.Rnd.NextDouble();
            double sum = 0.0;
            for (action = 0; action < traitsNum; action++)
            {
                sum += Traits[action];
                if (sum >= rnd)
                    break;
            }
            return action % 8;
        }

        public Color GetTraitColor(int val)
        {
            int red = 255;
            int green = 255;
            double x = Traits[val] - 0.5;
            if (x > 0)
                red = 255 - (int)(510 * Math.Abs(x));
            else if (x < 0)
                green = 255 - (int)(510 * Math.Abs(x));
            return Color.FromArgb(200, red, green, 0);
        }
    }
}
