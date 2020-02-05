using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace EvalutionSimulation
{
    public class World
    {
        public bool[,] Food = new bool[ESConfigsDefault.CELLS_X, ESConfigsDefault.CELLS_Y];
        public Bitmap foodBitmap;

        public World()
        {
            InitFoodArrey();
        }

        public void Reset()
        {
            InitFoodArrey();
        }

        public void InitFoodArrey()
        {
            foodBitmap = new Bitmap(ESConfigsDefault.CELLS_X, ESConfigsDefault.CELLS_X);
            using (Graphics g = Graphics.FromImage(foodBitmap))
            {
                g.Clear(ESConfigsDefault.BG_COLOR);
            }
            int foodNum = ESConfigsDefault.CELLS_X * ESConfigsDefault.CELLS_Y / 4;
            for (int i = 0; i < foodNum; i++)
            {
                int x = ESConfigsDefault.Rnd.Next(ESConfigsDefault.CELLS_X);
                int y = ESConfigsDefault.Rnd.Next(ESConfigsDefault.CELLS_Y);
                Food[x, y] = true;
                foodBitmap.SetPixel(x, y, ESConfigsDefault.FOOD_COLOR);
            }
        }

        public bool EatFood(int x, int y)
        {
            if (Food[x, y])
            {
                Food[x, y] = false;
                foodBitmap.SetPixel(x, y, ESConfigsDefault.BG_COLOR);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddFood()
        {
            //CONFIGS!!!
            //if (ESConfigsDefault.FOOD_RULE == FoodRule.Normal)
            //{
            //    SpawnFoodNormal(ESConfigsDefault.FOOD_PER_TICK);
            //}
            //else if (ESConfigsDefault.FOOD_RULE == FoodRule.Square)
            //{
            //    SpawnFoodNormal(ESConfigsDefault.FOOD_PER_TICK / 2);
            //    SpawnFoodSquare(ESConfigsDefault.FOOD_PER_TICK);
            //}
            if (ESConfigsDefault.FOOD_RULE == FoodRule.Normal)
            {
                SpawnFoodNormal(Form1.Configs.FoodPerTick);
            }
            else if (ESConfigsDefault.FOOD_RULE == FoodRule.Square)
            {
                SpawnFoodNormal(Form1.Configs.FoodPerTick / 2);
                SpawnFoodSquare(Form1.Configs.FoodPerTick);
            }
        }

        private void SpawnFoodNormal(int count)
        {
            for (int i = 0; i < count; i++)
            {
                int x = ESConfigsDefault.Rnd.Next(ESConfigsDefault.CELLS_X);
                int y = ESConfigsDefault.Rnd.Next(ESConfigsDefault.CELLS_Y);
                Food[x, y] = true;
                foodBitmap.SetPixel(x, y, ESConfigsDefault.FOOD_COLOR);
            }
        }

        private void SpawnFoodSquare(int count)
        {
            int SquarXMin = 5 * ESConfigsDefault.CELLS_X / 12;
            int SquarYMin = 5 * ESConfigsDefault.CELLS_Y / 12;
            int SquarXMax = 7 * ESConfigsDefault.CELLS_X / 12;
            int SquarYMax = 7 * ESConfigsDefault.CELLS_Y / 12;

            for (int i = 0; i < count; i++)
            {
                int x = ESConfigsDefault.Rnd.Next(SquarXMin, SquarXMax);
                int y = ESConfigsDefault.Rnd.Next(SquarYMin, SquarYMax);
                Food[x, y] = true;
                foodBitmap.SetPixel(x, y, ESConfigsDefault.FOOD_COLOR);
            }
        }
    }
}
