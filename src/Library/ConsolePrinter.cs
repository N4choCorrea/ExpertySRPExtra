using System;
using System.Collections;
namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        //Aca usamos SRP ya que la clase ConsolePrinter solo se encarga de imprimir en consola
        public void PrintBuilding( Building building)
        {
            Console.WriteLine($"Edificio {building.Description}:");
            Console.WriteLine(building.PrintBuilding());
            if (building.GetProductionCost() < 0)
            {
                throw new Exception("El costo no puede ser negativo");
            }
            else if (building.GetProductionCost() == 0)
            {
                throw new Exception("El costo no puede ser cero");
            }
            else
            {
                Console.WriteLine($"Costo de producción total: {building.GetProductionCost()}");
            }
            
        }
    }
}