//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Building : IPrintable, ICostable
    {
        private ArrayList tasks = new ArrayList();

        public Building(string name)
        {
            this.Description = name;
        }

        public string Description { get; set; }
        //no permitir que cualquiera pueda agregar o quitar tareas, que cada
        public void AddTask(Supply material, double quantity, Tool equipment, int time)
        {
            Task task = new Task(material, quantity, equipment, time);
            this.tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            this.tasks.Remove(task);
        }
        //Aca usamos el principio de experto ya que la clase Building es la que tenia la informacion ncesaria
        //para poder cumplir con la responsabilidad de calcular el costo de la tareabulding rombo a task flecha
        public double GetProductionCost()
        {
            ArrayList tasks = this.tasks;
            double costoTotal = 0;
            double costoUnitario = 0;
            foreach (Task task in tasks)
            {
                double CostoUnitario = task.Material.UnitCost;
                int tiempo = task.Time;
                double CostoTotalportarea = CostoUnitario * tiempo;
                costoUnitario = costoUnitario + CostoTotalportarea;
                double Equipo = task.Equipment.HourlyCost;
                double CostoTotal = costoUnitario + Equipo;
            }
            return (costoTotal);
            if (costoTotal < 0)
            {
                throw new Exception("El costo no puede ser negativo");
            }
            else if (costoTotal == 0)
            {
                throw new Exception("El costo no puede ser cero");
            }
        }
        public string PrintBuilding()
        {
            Console.WriteLine($"Edificio {this.Description}:");
            foreach (Task task in this.tasks)
            {
                Console.WriteLine($"{task.Quantity} de '{task.Material.Description}' " +
                    $"usando '{task.Equipment.Description}' durante {task.Time}");
            }
            return $"Costo de la tarea: {this.GetProductionCost()}";
        }

        
    }
}