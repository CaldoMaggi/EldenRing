using UnityEngine;

public class Confesor : Player
{
     private SpriteRenderer spriteRenderer;
     private Sprite confesorSprite;
    void Start()
    {
        Nombre = "Confesor";
        Level = 10;
        Vida = 414;
        Concentracion = 88;
        Estamina = 96;
        PoderFisico = 50;
        PoderSanto = 70;
        EquipLoad = "Mediano";
        Parry = true;

        Debug.Log($"Vida del jugador: {Vida}");
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

