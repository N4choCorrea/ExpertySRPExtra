using System;
namespace Full_GRASP_And_SOLID.Library
{
    public interface ICostable
    {
        double GetProductionCost();
    }
    //Aplicamos el patron ISP, debido a que creamos esta interfaz con un metodo que se utiliza en varias clases
    //y es un metodo que se puede implementar en las clases que se necesita y no tiene ningun metodo que las clases que lo implementan 
    //no necesiten, por lo que se cumple con el principio de segregacion de interfaces
}