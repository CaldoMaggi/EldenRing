using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{
    private float vidaMax;
    private float vidaActual;
    private float velocidad = 5f;

    private float horizontalInput;
    private float verticalInput;
    private Rigidbody2D rb;

    void Awake()
    {
        // Se deshabilita solo al instanciarse en Escena 0
        enabled = false;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (GameManager.instancia != null)
        {
            vidaMax = GameManager.instancia.Vida;
            vidaActual = vidaMax;
            Debug.Log($"Control listo: {GameManager.instancia.Nombre} | Vida: {vidaMax}");
        }
        else
        {
            vidaMax = 100f;
            vidaActual = vidaMax;
            Debug.LogWarning("GameManager no encontrado, usando valores por defecto.");
        }
    }

    void Update() //movimiento simple con WASD o flechas
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector2.right * Time.deltaTime * velocidad * horizontalInput);
        transform.Translate(Vector2.up * Time.deltaTime * velocidad * verticalInput);
    }

    public void RecibirDaño(float cantidad) //cada que demonio toque al jugador resta vida
    {
        vidaActual -= cantidad;
        vidaActual = Mathf.Max(vidaActual, 0f);

        Debug.Log($"{GameManager.instancia.Nombre} recibió {cantidad} daño. " +
                  $"Vida: {vidaActual}/{vidaMax}");

        if (vidaActual <= 0f)
            Morir();
    }

    private void Morir()
    {
        Debug.Log($"¡{GameManager.instancia.Nombre} ha muerto!");
        // gameObject.SetActive(false);
    }

    public float GetVidaPorcentaje() => vidaActual / vidaMax;
}