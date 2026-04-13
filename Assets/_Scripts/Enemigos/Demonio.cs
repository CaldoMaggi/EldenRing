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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"[Demonio] Colisión con: {collision.gameObject.name} | Tag: {collision.gameObject.tag}");

        if (!collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("[Demonio] No es Player, ignorando.");
            return;
        }

        if (collision.gameObject.TryGetComponent<ControlPersonaje>(out var player))
        {
            player.RecibirDaño(danio);
        }
        else
        {
            Debug.LogError("[Demonio] No encontró ControlPersonaje en el jugador!");
        }
    }
}