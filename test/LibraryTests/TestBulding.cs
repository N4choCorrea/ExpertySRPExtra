using NUnit.Framework;
using System;
using System.Collections.Generic;
using Full_GRASP_And_SOLID.Library;
namespace Tests
{
    public class TestBuilding
    {
        [Test]
        public void TestGetProductionCost()
        {
            Building building = new Building("Torre");
            building.AddTask(new Supply("Cemento", 100), 100, new Tool("Hormigonera", 1000), 120);
            building.AddTask(new Supply("Arena", 200), 200, new Tool("Hormigonera", 1000), 120);
            building.AddTask(new Supply("Tabla", 300), 50, new Tool("Martillo", 2000), 15);
            try
            {
                building.GetProductionCost();
            }
            catch (Exception )
            {
                Assert.Fail("No debería haber lanzado excepción");
            }
        }
        [Test]
        public void TestConsolePrinter()
        {
            Building building = new Building("Torre");
            building.AddTask(new Supply("Cemento", 100), 100, new Tool("Hormigonera", 1000), 120);
            building.AddTask(new Supply("Arena", 200), 200, new Tool("Hormigonera", 1000), 120);
            building.AddTask(new Supply("Tabla", 300), 50, new Tool("Martillo", 2000), 15);
            ConsolePrinter printer = new ConsolePrinter();
            try
            {
                printer.PrintBuilding(building);
            }
            catch (Exception)
            {
                Assert.Fail("No debería haber lanzado excepción");
            }
        }
        
    }
}