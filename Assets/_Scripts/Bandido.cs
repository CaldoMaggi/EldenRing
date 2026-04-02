using System;
using UnityEngine;

public class Bandido : Player
{
    public Sprite spriteBandido;

    public Bandido() : base("Bandido", 5, 414, 82, 70, 0, 0, 96, "Mediano")
    {
    }
    public void Atacar()
    {
        Debug.Log($"{Nombre}+  ataca con su cuchillo y hace {PoderFisico}  puntos de daño");
    }
    public void AtacarArco()
    {
        Debug.Log($"{Nombre} +  ataca con su arco corto y hace  {PoderFisico - 20} puntos de daño");
    }

    public void ParryAble()
    {
        Parry = true;
        Debug.Log($"{Nombre} {(enabled ? "bloquea" : "deja de bloquear")} con su escudo");
    }
}

