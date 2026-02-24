using UnityEngine;

public class Player : MonoBehaviour
{
    // Atributos del jugador independiente de la clase escogida
    private string nombre;
    private int level;
    private int vida;
    private int concentracion; //mana
    private int poderFisico;
    private int poderMagico;
    private int poderSanto;
    private int estamina;
    private string equipLoad; //ligero,mediano,pesado
    private bool parry = false;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Level
    {
        get { return level; }
        set { level = Mathf.Max(1, value); } // nunca menor que 1
    }

    public int Vida
    {
        get { return vida; }
        set { vida = Mathf.Max(0, value); } // nunca menor que 0
    }

    public int Concentracion
    {
        get { return concentracion; }
        set { concentracion = Mathf.Max(0, value); }
    }

    public int PoderFisico
    {
        get { return poderFisico; }
        set { poderFisico = Mathf.Max(0, value); }
    }

    public int PoderMagico
    {
        get { return poderMagico; }
        set { poderMagico = Mathf.Max(0, value); }
    }

    public int PoderSanto
    {
        get { return poderSanto; }
        set { poderSanto = Mathf.Max(0, value); }
    }

    public int Estamina
    {
        get { return estamina; }
        set { estamina = Mathf.Max(0, value); }
    }

    public string EquipLoad
    {
        get { return equipLoad; }
        set { equipLoad = value; }
    }

    public bool Parry
    {
        get { return parry; }
        set { parry = value; }
    }


}

