using System;
using UnityEngine;

public class Miserable : Player
{
    public Sprite spriteMiserable;
    private void Awake()
    {
        Level = 1;
        Nombre = "Miserable";
        Vida = 414;
        Concentracion = 78;
        Estamina = 96;
        PoderFisico = 40;
        EquipLoad = "ligero";
        Parry = false;
        if (spriteRenderer != null && spriteMiserable != null) //que haya un sprite renderer y un sprite asignado
        {
            spriteRenderer.sprite = spriteMiserable;
        }
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

