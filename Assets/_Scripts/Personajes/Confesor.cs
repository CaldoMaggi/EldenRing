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
        Debug.Log($"{Nombre} lanza un encantamiento y hace {PoderSanto} puntos de daño");
    }

    public void ParryAble(bool enabled)
    {
        Parry = enabled;
        Debug.Log($"{Nombre} {(enabled ? "bloquea" : "deja de bloquear")} con su escudo"); // Si enabled es true, el mensaje dirá "bloquea", de lo contrario dirá "deja de bloquear"
    }
}

