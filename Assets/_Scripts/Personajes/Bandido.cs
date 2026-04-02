using System;
using UnityEngine;

public class Bandido : Player
{
    public Sprite spriteBandido;

    public Bandido() : base("Bandido", 5, 414, 82, 10, 0, 0, 96, "Mediano")
    {
    }
    public void Atacar()
    {
        Debug.Log($"{Nombre}+  ataca con sus puños y hace {PoderFisico}  puntos de daño");
    }
    public void AtacarArco()
    {
        Debug.Log($"{Nombre} +  ataca con su arco corto y hace  {PoderFisico + 60} puntos de daño");
    }
}

