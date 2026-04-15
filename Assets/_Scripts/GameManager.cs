using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia;

    // El prefab original para instanciar en Escena 1
    private GameObject prefabSeleccionado;

    // atributos leídos en Escena 0
    public string Nombre { get; private set; }
    public int Level { get; private set; }
    public int Vida { get; private set; }
    public int Concentracion { get; private set; }
    public int PoderFisico { get; private set; }
    public int PoderMagico { get; private set; }
    public int PoderSanto { get; private set; }
    public int Estamina { get; private set; }
    public string EquipLoad { get; private set; }
    public bool Parry { get; private set; }

    void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void GuardarSeleccion(GameObject prefab)
    {
        prefabSeleccionado = prefab;

        // Lee los valores del GameObject instanciado en Escena 0
        // que ya tiene el script Player y sus hijos con sus valores
        Player p = prefab.GetComponent<Player>();

        if (p != null)
        {
            Nombre = p.Nombre;
            Level = p.Level;
            Vida = p.Vida;
            Concentracion = p.Concentracion;
            PoderFisico = p.PoderFisico;
            PoderMagico = p.PoderMagico;
            PoderSanto = p.PoderSanto;
            Estamina = p.Estamina;
            EquipLoad = p.EquipLoad;
            Parry = p.Parry;

            Debug.Log($"Guardado: {Nombre} | Vida: {Vida} | Mana: {Concentracion}");
        }
        else
        {
            Debug.LogError("El prefab no tiene componente Player!");
        }
    }

    public GameObject ObtenerPrefabSeleccionado()
    {
        return prefabSeleccionado; //llama la variable que contiene la información del prefab
    }

}