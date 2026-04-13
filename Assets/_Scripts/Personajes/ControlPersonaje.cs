using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{
    private float vidaMax;
    private float vidaActual;
    private float velocidad = 5f;

    private float horizontalInput;
    private float verticalInput;
    private Rigidbody2D rb;
    [SerializeField]private SpriteRenderer spriteRenderer;

    void Awake()
    {
        // Se deshabilita solo al instanciarse en Escena 0(para q no se mueva en el menu)
        enabled = false;
    }

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            Debug.LogError("¡Oye! El objeto " + gameObject.name + " no tiene un SpriteRenderer.");
        }
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
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Creamos el vector de movimiento
        Vector3 direccion = new Vector3(horizontal, vertical, 0);

        // Movimiento usando Space.World para que no se inviertan los controles
        transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);

        VoltearSprite(horizontal);
    }

    void VoltearSprite(float horizontal)
    {
        if (horizontal < -0.1f)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        // Si presiona derecha, volvemos a 0 grados
        else if (horizontal > 0.1f)
        {
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
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
        gameObject.SetActive(false);
    }

    public float GetVidaPorcentaje() => vidaActual / vidaMax;
}