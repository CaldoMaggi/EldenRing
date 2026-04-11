using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public GameObject PrefabSeleccionado { get; private set; }

    public Transform puntoDeSpawn;

    public void GuardarSeleccion(GameObject prefab)
    {
        PrefabSeleccionado = prefab;
    }

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject); // sobrevive al cambio de escena
    }
    void Start()
    {
        GameObject prefab = GameManager.Instance.PrefabSeleccionado;

        if (prefab != null)
        {
            Instantiate(prefab, puntoDeSpawn.position, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("No hay personaje seleccionado");
        }
    }
}
