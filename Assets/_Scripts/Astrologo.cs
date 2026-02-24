using System;
using UnityEngine;

public class Astrologo : Player
{
    private void Start()
    {
        Level = 6;
        Nombre = "Astrologo";
        Vida = 396;
        Concentracion = 95;
        Estamina = 94;
        PoderFisico = 20;
        PoderMagico = 90;
        EquipLoad = "ligero";
        Parry = true;
    }
    public void AtacarFisico()
    {
        Debug.Log($"{Nombre} ataca con su espada y hace {PoderFisico} puntos de daño");
    }
    public void AtacarMagico()
    {
        Debug.Log($"{Nombre} lanza un guijarro de destellita y hace {PoderMagico} puntos de daño");
    }

    public void ParryAble()
    {
        Parry = true;
        Debug.Log($"{Nombre} bloquea con su escudo de madera y reduce el daño recibido");
    }
}

