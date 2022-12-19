using System;
using System.Collections;
using System.IO;
namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter : IPrinter
    {
        //Aca usamos SRP ya que la clase ConsolePrinter solo se encarga de imprimir en consola
        public void PrintBuilding(IPrintable building)
        {
            Console.WriteLine(building.PrintBuilding());
            
        }
    }
}