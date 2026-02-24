using UnityEngine;
using TMPro;

public class MenuSelection : MonoBehaviour
{
    public GameObject astrologoPrefab;
    public GameObject miserablePrefab;
    public GameObject confesorPrefab;
    public GameObject bandidoPrefab;
    public GameObject personajeActual;

    public Vector3 spawnPosition = new Vector3(0, 0, 0);

    public TextMeshProUGUI nombreText;
    public TextMeshProUGUI atributosText;

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
        personajeActual = Instantiate(prefab, spawnPosition, Quaternion.identity);
        Debug.Log("Personaje seleccionado: " + personajeActual.name + "Presiona espacio para atacar");
        nombreText.text = personajeActual.name;
        Player playerScript = personajeActual.GetComponent<Player>();
        if (playerScript != null)
        {
            atributosText.text = "Vida: " + playerScript.Vida + "\n" +
                                  "Concentración: " + playerScript.Concentracion + "\n" +
                                  "Poder Físico: " + playerScript.PoderFisico + "\n" +
                                  "Poder Mágico: " + playerScript.PoderMagico + "\n" +
                                  "Poder Santo: " + playerScript.PoderSanto + "\n" +
                                  "Estamina: " + playerScript.Estamina;

        }
    }
}
