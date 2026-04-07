using UnityEngine;

public class Enemigo : MundoEntidades, IDañable
{
    private string nombre;
    private int vida;

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
            Debug.Log($"El {nombre} ha muerto");
        }
    }

    // Metodo abstracto de MundoEntidades
    public override void Interactuar()
    {
        Debug.Log($"El {nombre} te ataca. Preparate para morir"); 
    }
}