using UnityEngine;

public class Item : MundoEntidades, IGuardable
{
    private string nombre;
    private string descripcion;

    // Metodo de IGuardable
    public void AnadirAlInventario()
    {
        Debug.Log($"El {nombre} ha sido aniadido al inventario"); 
    }

    // Metodo de IGuardable
    public void EliminarDelInventario()
    {
        Debug.Log($"El {nombre} ha sido eliminado del inventario"); 
    }

    // Metodo abstracto de MundoEntidades
    public override void Interactuar()
    {
        Debug.Log($"Recoges '{nombre}'. {descripcion}");
        AnadirAlInventario();
    }
}
