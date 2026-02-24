using System;
using UnityEngine;

public class Confesor : Player
{
    void Start()
    {
        Player jugador = FindObjectOfType<Player>();

        // Leer valores
        Debug.Log("Vida del jugador: " + jugador.Vida);

        // Modificar valores
        jugador.Vida -= 20;
        jugador.Level = 5;
        jugador.Nombre = "Arthur";
    }

    private void Start()
    {
        level = 10;
        nombre = "Confesor";
        vida = 414;
        concentracion = 88;
        estamina = 96;
        poderFisico = 50;
        poderSanto = 70;
        equipLoad = "mediano";
    }
    public void AtacarFisico()
    {
        Debug.Log(nombre + " ataca con su espada y hace " + poderFisico + " puntos de daño");
    }

    public void AtacarSanto()
    {
        Debug.Log(nombre + " lanza un encantamiento y hace " + poderSanto + " puntos de daño");
    }

    public void Parry()
    {
        parry = true;
        Debug.Log(nombre + " bloquea con su escudo azul de la grieta y reduce el daño recibido");
    }
}

