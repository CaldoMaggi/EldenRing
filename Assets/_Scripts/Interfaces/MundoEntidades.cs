using UnityEngine;

public abstract class MundoEntidades
{
    private string nombre; // Nombre del ser
    private Vector2 posicion; // Posición en el mundo del ser

    public void Aparecer()
    {
        Debug.Log($"El {nombre} ha aparecido en el mundo");// Método para la aparición del ser
    }

    public void Posicion()
    {
        Debug.Log($"El {nombre} se encuentra en la posición {posicion}");// Método para la posición del ser
    }

    public void Interactuar()
    {
        Debug.Log($"El {nombre} es interactuable");// Método para la interacción del ser
    }
}
