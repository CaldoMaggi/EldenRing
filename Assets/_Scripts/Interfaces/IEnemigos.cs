using UnityEngine;

public interface IEnemigos
{
    public void RecibirDaño(float cantidad);

    public abstract void Morir();

    public void Ataque(GameObject objetivo);
}
