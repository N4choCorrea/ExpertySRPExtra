using System;
namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrintable
    {
        string PrintBuilding();
    }
}
// Aqui aplicamos el patron DIP, debido a que creamos esta interfaz para que la clases dependan 
// de una abstraccion para que una clase no dependa de una clase concreta, sino que dependa de una abstraccion
//ahora podemos agregar cambios en las diferentes clases sin afectar a las demas clases, por ejemplo building,
// ya que ahora unas no depende de la otra, sino que depende de una abstraccion, en este caso la interfaz IPrintable