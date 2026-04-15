using UnityEngine;

public abstract class MundoEntidades : MonoBehaviour
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

    public virtual void Interactuar()
    {
        Debug.Log($"El {nombre} es interactuable"); // comportamiento por defecto
    }

}
