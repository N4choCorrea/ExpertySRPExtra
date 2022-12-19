using System;
using System.Collections;
using System.IO;
namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
        public void PrintBuilding(IPrintable building)
        {
            File.WriteAllText("Building.txt", building.PrintBuilding());
        }
    }
}