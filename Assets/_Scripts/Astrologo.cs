using System;
using UnityEngine;

public class Astrologo : Player
{
    private void Start()
    {
        level = 6;
        nombre = "Astrologo";
        vida = 396;
        concentracion = 95;
        estamina = 94;
        poderFisico = 20;
        poderMagico = 90;
        equipLoad = "ligero";
    }
    public void AtacarFisico()
    {
        Debug.Log(nombre + " ataca con su espada y hace " + poderFisico + " puntos de daño");
    }
    public void AtacarMagico()
    {
        Debug.Log(nombre + " lanza un guijarro de destellita y hace " + poderMagico + " puntos de daño");
    }

    public void Parry()
    {
        parry = true;
        Debug.Log(nombre + " bloquea con su escudo de madera y reduce el daño recibido");
    }
}

