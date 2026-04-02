using UnityEngine;

public abstract class MundoEntidades
{
    public string nombre; // Nombre del ser
    public void Descripcion()
    {
        Debug.Log($"Este es un {nombre}");// Método para el nombre del ser
    }

}
