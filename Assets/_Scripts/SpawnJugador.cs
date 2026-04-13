using UnityEngine;

public class SpawnJugador : MonoBehaviour
{
    [SerializeField] private Transform puntoDeSpawn;

    void Start()
    {
        if (GameManager.instancia == null)
        {
            Debug.LogError("No hay GameManager en la escena!");
            return;
        }

        GameObject prefab = GameManager.instancia.ObtenerPrefabSeleccionado();

        if (prefab == null)
        {
            Debug.LogError("No hay personaje seleccionado!");
            return;
        }

        GameObject jugador = Instantiate(prefab, puntoDeSpawn.position, Quaternion.identity);
        jugador.name = prefab.name;
        jugador.tag = "Player"; // ← garantiza el tag aunque el prefab no lo tenga

        ControlPersonaje control = jugador.GetComponent<ControlPersonaje>();
        if (control == null)
            control = jugador.AddComponent<ControlPersonaje>();

        control.enabled = true;
    }
}