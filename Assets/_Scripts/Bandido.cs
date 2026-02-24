using System;
using UnityEngine;

public class Bandido : Player
{
    public Sprite spriteBandido;
    private void Awake()
    {
        Level = 5;
        Nombre = "Bandido";
        Vida = 414;
        Concentracion = 82;
        Estamina = 96;
        PoderFisico = 70;
        EquipLoad = "Mediano";
        Parry = true;
        if (spriteRenderer != null && spriteBandido != null) //que haya un sprite renderer y un sprite asignado
        {
            spriteRenderer.sprite = spriteBandido;
        }
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

