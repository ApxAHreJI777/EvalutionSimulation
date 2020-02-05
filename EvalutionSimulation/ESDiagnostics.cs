using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvalutionSimulation
{
    public class ESDiagnostics
    {
        double[] trts = new double[Gene.traitsNum];
        int energySum = 0;
        public int Count = 0;

        public void Add(Microbe m)
        {
            Count++;
            for (int i = 0; i < trts.Length; i++)
            {
                trts[i] += m.Genes.Traits[i];
            }
            energySum += m.Energy;
        }

        public Microbe AvgStats()
        {
            double[] avgTrt = new double[Gene.traitsNum];
            int avgEnergy = 0;
            if (Count > 0)
            {
                for (int i = 0; i < trts.Length; i++)
                {
                    avgTrt[i] = (double)(trts[i] / Count);
                }
                avgEnergy = energySum / Count;
            }

            return new Microbe(0, 0, 0, avgEnergy, new Gene(avgTrt));
        }
    }

    public class ESLifeTimeChart
    {
        public Queue<int> que = new Queue<int>();
        public int MaxLength = 0;

        public ESLifeTimeChart(int max)
        {
            MaxLength = max;
        }

        public void Add(int val)
        {
            que.Enqueue(val);
            if (que.Count > MaxLength)
                que.Dequeue();
        }

        public void Clear()
        {
            que.Clear();
        }
    }
}
