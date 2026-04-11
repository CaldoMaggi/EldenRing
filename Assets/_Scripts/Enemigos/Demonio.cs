using UnityEngine;

public class Demonio : Enemigo
{
    protected override void Awake()
    {
        base.Awake();
        nombre = "Demonio";
        vida = 100;
        danio = 10;
        Debug.Log($"[Demonio] Awake ejecutado — danio: {danio}");
    }

    private void OnCollisionEnter2D(Collision2D collision)  // 👈 2D
    {
        Debug.Log($"[Demonio] Colisión 2D detectada con: {collision.gameObject.name}");

        if (!collision.gameObject.CompareTag("Player")) return;

        if (collision.gameObject.TryGetComponent<ControlPersonaje>(out var player))
        {
            player.RecibirDaño(danio);
            Debug.Log($"[{nombre}] tocó al jugador — {danio} de daño.");
        }
    }
}