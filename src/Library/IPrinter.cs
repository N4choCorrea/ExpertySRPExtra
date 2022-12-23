namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        void PrintBuilding(Building building);
    }
    //Aplicando esta interfaz se puede imprimir en consola o en un archivo, por lo que aplicamos el patron poliformismo
    //porque la clase ConsolePrinter y FilePrinter implementan la interfaz IPrinter, y por tanto aplicamos operaciones 
    //polimorficas ya que su uso puede variar y si quisieramos cambiar algo ahora solo tendriamos que agregar una nueva clase 
    //que implemente la interfaz IPrinter sin tener que modificar las clases que ya estan implementadas
}