using UnityEngine;

public class Demonio : Enemigo
{
    public Demonio(string nombre, int vida, int danio) : base(nombre, vida, danio)
    {
        nombre = "Demonio";
        vida = 100;
        danio = 10;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;

        if (collision.gameObject.TryGetComponent<ControlPersonaje>(out var player))
        {
            player.RecibirDaño(danio);
            Debug.Log($"[{name}] tocó al jugador — {danio} de daño.");
        }
    }
}
