using UnityEngine;

public class Demonio : Enemigo
{
    protected override void Awake()
    {
        base.Awake();
        nombre = "Demonio";
        vida = 200; 
        danio = 100;
        Debug.Log($"Demonio ha aparecido y hace {danio} daño al tocarlo");
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