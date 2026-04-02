using UnityEngine;

public class Confesor : Player
{
    public Sprite spriteConfesor;

    public Confesor() : base("Confesor", 10, 414, 88, 50, 0, 70, 96, "Mediano")
    {
    }
    public void AtacarFisico()
    {
        Debug.Log($"{Nombre} ataca con su espada y hace {PoderFisico} puntos de daño");
    }

    public void AtacarSanto()
    {
        Debug.Log($"{Nombre} hace un milagro y hace {PoderSanto} puntos de daño");
    }

    public void ParryAble()
    {
        Parry = true;
        Debug.Log($"{Nombre}con su escudo");
    }
}

