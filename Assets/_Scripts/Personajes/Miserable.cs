using System;
using UnityEngine;

public class Miserable : Player
{
    public Sprite spriteMiserable;

    public Miserable() : base("Miserable", 1, 414, 78, 40, 0, 0, 96, "ligero")
    {
    }
    public void Atacar()
    {
        Debug.Log($"{Nombre} ataca con su garrote y hace {PoderFisico} puntos de daño");
    }

    public void ParryAble()
    {
        Parry = false;
        Debug.Log($"{Nombre} no puede bloquear sin escudo");
    }
}

