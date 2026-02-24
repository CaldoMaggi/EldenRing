using System;
using UnityEngine;

public class Bandido : Player
{
    private void Start()
    {
        level = 5;
        nombre = "Bandido";
        vida = 414;
        concentracion = 82;
        estamina = 96;
        poderFisico = 70;
        equipLoad = "mediano";
    }
    public void Atacar()
    {
        Debug.Log(nombre + " ataca con su cuchillo y hace " + poderFisico + " puntos de daño");
    }
    public void AtacarArco()
    {
        Debug.Log(nombre + " ataca con su arco corto y hace " + (poderFisico - 20) + " puntos de daño");
    }

    public void Parry()
    {
        parry = true;
        Debug.Log(nombre + " bloquea con su broquel y reduce el daño recibido");
    }
}

