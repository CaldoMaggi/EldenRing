using UnityEngine;

public class Astrologo : Player
{
    public Astrologo() : base("Astrologo", 6, 396, 95, 94, 10, 90, 96, "ligero")
    {
    }
    public void Atacar()
    {
        Debug.Log($"{Nombre}+  ataca con sus puños y hace {PoderFisico}  puntos de daño");
    }
    public void AtacarMagico()
    {
        Debug.Log($"{Nombre} ataca con su bastón y hace {PoderMagico} puntos de daño");
    }
}

