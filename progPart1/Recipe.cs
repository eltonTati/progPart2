﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progPart1
{
    internal class Recipe
    {
        public Ingredient[] Ingredients { get; set; }
        public string[] Steps { get; set; }
        private double[] FirstQuant { get; set; }

        public Recipe(int ingredientCount, int stepCount)
        {
            Ingredients = new Ingredient[ingredientCount];
            FirstQuant = new double[ingredientCount];
            Steps = new string[stepCount];
        }

        public void Disp()
        {
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} {ingredient.Name}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < Steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i]}");
            }
        }

        public void Scale(double factor)
        {
            for (int i = 0; i < Ingredients.Length; i++)
            {
                Ingredients[i].Quantity *= factor;
            }
        }

        public void ResetQuantities()
        {
            for (int i = 0; i < Ingredients.Length; i++)
            {
                Ingredients[i].Quantity = FirstQuant[i];
            }
        }

        public void Clear()
        {
            Array.Clear(Ingredients, 0, Ingredients.Length);
            Array.Clear(Steps, 0, Steps.Length);
        }

        public void ReservedQuantities()
        {
            for (int i = 0; i < Ingredients.Length; i++)
            {
                FirstQuant[i] = Ingredients[i].Quantity;
            }
        }
    }
}