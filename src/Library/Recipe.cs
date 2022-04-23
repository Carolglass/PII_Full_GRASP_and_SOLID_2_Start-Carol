//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        //Se decide crear un método para poder acceder a los pasos de la receta desde otra clase.
        //En este caso, se desea acceder desde la nueva clase ConsolePrinter la cual imprimirá por consola la receta en su totalidad.
        //Cumpliendo con el ejercicio y el principio SRP.

        public ArrayList GetSteps()
        {
            return steps;
        }

        //El error está en que la receta no debería tener la responsabilidad de imprimirse a si misma

        /*public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }*/
    }
}