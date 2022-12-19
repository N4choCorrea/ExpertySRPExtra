//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    /*public enum Destination
    {
        Console,
        File
    }*/

    public class AllInOnePrinter
    {
        public void PrintBuilding(Building building, IPrinter destination)
        {
            /*if (destination == Destination.Console)
            {
                Console.WriteLine(building.PrintBuilding());
            }
            else
            {
                File.WriteAllText("Building.txt", building.PrintBuilding());
            }*/
        }
    }
}