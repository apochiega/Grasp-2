using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        Recipe receta = new Recipe ();

        public void PrintRecipe(Recipe receta)
        {
            Console.WriteLine($"Receta de {receta.FinalProduct.Description}:");
            foreach (Step step in receta.getSteps())
            {
                Console.WriteLine($"{step.Quantity} de :'{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}
