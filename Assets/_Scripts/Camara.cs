using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    public KeyCode switchKey;

    public GameObject jugador;
    private Vector3 offset = new Vector3(0, 6, -10);

    private void FixedUpdate()
    {
        transform.position = jugador.transform.position + offset;
    }
}