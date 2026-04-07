using UnityEngine;

public abstract class MundoEntidades
{
    private string nombre; // Nombre del ser
    private Vector2 posicion; // Posici�n en el mundo del ser

    public void Aparecer()
    {
        Debug.Log($"El {nombre} ha aparecido en el mundo");// M�todo para la aparici�n del ser
    }

    public void Posicion()
    {
        Debug.Log($"El {nombre} se encuentra en la posici�n {posicion}");// M�todo para la posici�n del ser
    }

    public abstract void Interactuar();
    // Interactuar no me lo lee como abstracto, por eso concatene.
   /* {
        Debug.Log($"El {nombre} es interactuable");// M�todo para la interacci�n del ser
    }*/
}
