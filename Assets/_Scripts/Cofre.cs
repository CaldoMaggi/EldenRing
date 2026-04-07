using UnityEngine;

public class Cofre : MundoEntidades, IDañable, IGuardable
{
    private string nombre;
    private int vida = 80;
    protected bool esMimic = false; //Protected para ser asignado en el instector

    // Propiedad de IDanable
    public int Vida
    {
        get { return vida; }
        set { vida = value; }
    }

    // Metodo de IDanable
    public void RecibirDanio(int danio)
    {
        Vida -= danio;
        Debug.Log($"El {nombre} ha recibido {danio} de daño. Vida restante: {Vida}");

        if (Vida <= 0)
        {
            Debug.Log($"El {nombre} ha sido destruido. Suelta su contenido");
        }
    }

    // Metodo de IGuardable
    public void AnadirAlInventario()
    {
        Debug.Log($"El {nombre} ha sido añadido al inventario como item especial"); 
    }

    // Metodo de IGuardable
    public void EliminarDelInventario()
    {
        Debug.Log($"El {nombre} ha sido eliminado del inventario"); 
    }

    // Metodo abstracto de MundoEntidades
    public override void Interactuar()
    {
        if (esMimic)
        {
            Debug.Log($"El {nombre} era un Mimic! Te ataca");
        }
        else
        {
            Debug.Log($"Abres el {nombre}. Encuentras algo valioso");
            AnadirAlInventario();
        }
    }
}