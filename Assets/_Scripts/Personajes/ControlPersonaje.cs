using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{

    [SerializeField] private float vidaMax = 100f;
    private float vidaActual;

    private float velocidad = 5f;
    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
        // Movimiento simple
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * Time.deltaTime * velocidad * verticalInput);
        transform.Translate(Vector2.right * Time.deltaTime * velocidad * horizontalInput);
    }
    private void Start()
    {
        vidaActual = vidaMax;
    }

    public void RecibirDaño(float cantidad)
    {
        vidaActual  -= cantidad;
        Debug.Log($"Jugador recibió {cantidad} de daño. Salud: {vidaActual}/{vidaMax}");

        if (vidaActual <= 0f)
        {
            vidaActual = 0f;
            Debug.Log("¡El jugador murió!");
        }
    }
}
