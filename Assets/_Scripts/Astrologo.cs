using UnityEngine;

public class Astrologo : Player
{
    public Sprite spriteAstrologo;
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
        if (spriteRenderer != null && spriteAstrologo != null) //que haya un sprite renderer y un sprite asignado
        {
            spriteRenderer.sprite = spriteAstrologo;
        }
    }
}

