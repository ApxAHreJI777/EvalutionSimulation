using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace EvalutionSimulation
{
    public enum MutationRule { Copy, Evalution, Random }
    public enum FoodRule { Normal, Square }
    public class ESConfigsDefault
    {
        public static MutationRule MUTATION_RULE = MutationRule.Evalution;
        public static FoodRule FOOD_RULE = FoodRule.Normal;
        
        public const int MAX_ENERGY = 1600;
        public const int REPRODUCE_ENERGY = 1000;
        public const int ENERGY_PER_MOVE = 1;
        public const int ENERGY_PER_FOOD = 40;
        public const int FOOD_PER_TICK = 20;
        public const int INIT_MIC_NUMBER = 10;
        
        public static Random Rnd = new Random();
        public static int CELLS_X = 400;
        public static int CELLS_Y = 400;
        public static Color FOOD_COLOR = Color.FromArgb(0, 255, 0);
        public static Color MIC_COLOR = Color.FromArgb(50, 155, 255);
        public static SolidBrush MIC_BRUSH = new SolidBrush(MIC_COLOR);
        public static Color MIC_COLOR_MARKED = Color.FromArgb(255, 155, 50);
        public static SolidBrush MIC_BRUSH_MARKED = new SolidBrush(MIC_COLOR_MARKED);
        public static Color BG_COLOR = Color.FromArgb(0, 0, 0);
        public static int DEFAULT_SPEED = 2;
        public static int[] SPEED_SETTINGS = { 160, 80, 40, 20, 10 };
    }

    public class ESConfigs
    {
        int maxEnergy = ESConfigsDefault.MAX_ENERGY;
        [CategoryAttribute("Microbe"),
        DescriptionAttribute("Maximum amount of energy microbe can consume."),
        DefaultValueAttribute(ESConfigsDefault.MAX_ENERGY)]
        public int MaxEnergy
        {
            get { return maxEnergy; }
            set 
            { 
                if (value > 0) maxEnergy = value;
                else maxEnergy = 1;
                if (value < repEnergy) repEnergy = value;
            }
        }

        int repEnergy = ESConfigsDefault.REPRODUCE_ENERGY;
        [CategoryAttribute("Microbe"),
        DescriptionAttribute("Amount of energy needed to reproduse."),
        DefaultValueAttribute(ESConfigsDefault.REPRODUCE_ENERGY)]
        public int ReproduceEnergy
        {
            get { return repEnergy; }
            set 
            {
                if (value < 0) repEnergy = 1;
                else if (value > maxEnergy) repEnergy = maxEnergy;
                else repEnergy = value; 
            }
        }

        int energyPerMove = ESConfigsDefault.ENERGY_PER_MOVE;
        [CategoryAttribute("Microbe"),
        DescriptionAttribute("Amount of energy needed to move."),
        DefaultValueAttribute(ESConfigsDefault.ENERGY_PER_MOVE)]
        public int EnergyPerMove
        {
            get { return energyPerMove; }
            set
            {
                if (value > 0) energyPerMove = value;
                else energyPerMove = 0;
            }
        }

        int microbesInitNumber = ESConfigsDefault.INIT_MIC_NUMBER;
        [CategoryAttribute("Microbe"),
        DescriptionAttribute("Initial amount of microbes."),
        DefaultValueAttribute(ESConfigsDefault.INIT_MIC_NUMBER)]
        public int MicrobesInitNumber
        {
            get { return microbesInitNumber; }
            set
            {
                if (value > 0) microbesInitNumber = value;
                else microbesInitNumber = 1;
            }
        }

        int energyPerFood = ESConfigsDefault.ENERGY_PER_FOOD;
        [CategoryAttribute("Food"),
        DescriptionAttribute("Amount of energy is gained per consumed food."),
        DefaultValueAttribute(ESConfigsDefault.ENERGY_PER_FOOD)]
        public int EnergyPerFood
        {
            get { return energyPerFood; }
            set
            {
                if (value > 0) energyPerFood = value;
                else energyPerFood = 0;
            }
        }

        int foodPerTick = ESConfigsDefault.FOOD_PER_TICK;
        [CategoryAttribute("Food"),
        DescriptionAttribute("The rate of spawning new food."),
        DefaultValueAttribute(ESConfigsDefault.FOOD_PER_TICK)]
        public int FoodPerTick
        {
            get { return foodPerTick; }
            set
            {
                if (value > 0) foodPerTick = value;
                else foodPerTick = 0;
            }
        }
    }
}
