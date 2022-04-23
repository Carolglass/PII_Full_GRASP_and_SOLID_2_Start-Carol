using System;
using System.Collections;

// Se crea la nueva clase de imprimir la receta en concola
// Se cumple con el principio SRP y Expert. 
// Pues en caso de en un futuro cambiar la salida de impresion de la receta, solo se debería cambiar la clase ConsolePrinter, tiene única razón de cambio.
// Tambien ciumple con Patron Expert, ya que esta clase es la experta en la información.   

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe receta)
        {
            Console.WriteLine($"Receta de {receta.FinalProduct.Description}:");
            foreach (Step step in receta.GetSteps())
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}