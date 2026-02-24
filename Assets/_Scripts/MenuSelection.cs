using UnityEngine;

public class MenuSelection : MonoBehaviour
{
    public GameObject astrologoPrefab;
    public GameObject miserablePrefab;
    public GameObject confesorPrefab;
    public GameObject bandidoPrefab;
    public GameObject personajeActual;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SeleccionarPersonaje(astrologoPrefab);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SeleccionarPersonaje(miserablePrefab);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SeleccionarPersonaje(confesorPrefab);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SeleccionarPersonaje(bandidoPrefab);
        }
    }

    void SeleccionarPersonaje(GameObject prefab)
    {
        if (personajeActual != null)
        {
            Destroy(personajeActual);
        }
        Debug.Log("Personaje seleccionado: " + personajeActual.name + "Presiona espacio para atacar");
    }

}
