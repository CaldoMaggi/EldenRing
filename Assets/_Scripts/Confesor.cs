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
        jugador.Level = 10;
        jugador.Nombre = "Confesor";
        jugador.Vida = 414;
        jugador.Concentracion = 88;
        jugador.Estamina = 96;
        jugador.PoderFisico = 50;
        jugador.PoderSanto = 70;
        jugador.EquipLoad = "mediano";
        jugador.Parry = true;
    }
    public void AtacarFisico()
    {
        Debug.Log(Nombre + " ataca con su espada y hace " + PoderFisico + " puntos de daño");
    }

    public void AtacarSanto()
    {
        Debug.Log(Nombre + " lanza un encantamiento y hace " + PoderSanto + " puntos de daño");
    }

    public void ParryAble()
    {
        Parry = true;
        Debug.Log(Nombre + " bloquea con su escudo azul de la grieta y reduce el daño recibido");
    }
}

