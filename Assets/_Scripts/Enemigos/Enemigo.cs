using System;
using UnityEngine;

public class Enemigo : MonoBehaviour, IEnemigos
{
    protected string nombre;
    protected int vida;
    protected int danio;
    public GameObject target;
    public Enemigo(string nombre, int vida, int danio)
    {
        this.nombre = nombre;
        this.vida = vida;
        this.danio = danio;
    }

    public void RecibirDaño(float cantidad)
    {
        vida -= (int)cantidad;
        if (vida <= 0)
        {
            Morir();
        }
    }

    public virtual void Morir()
    {
        Console.WriteLine($"{nombre} ha muerto.");
    } 
    
    public void Ataque(GameObject objetivo)
    {
        Console.WriteLine($"{nombre} ataca a {objetivo.name} causando {danio} de daño.");
        // Aquí podrías agregar lógica para reducir la vida del objetivo, etc.
    }

}