using UnityEngine;
using TMPro;
using NUnit.Framework;
using System.Collections.Generic;

public class MenuSelection : MonoBehaviour
{
    List<int> personajes = new List<int> {1,2,3,4};
    private int personajeSeleccionado = 0;
    public GameObject astrologoPrefab;
    public GameObject miserablePrefab;
    public GameObject confesorPrefab;
    public GameObject bandidoPrefab;
    public GameObject personajeActual;

    private Vector3 spawnPosition = new Vector3(4, -4, 0);

    public TextMeshProUGUI nombreText;
    public TextMeshProUGUI atributosText;

    public void NextCharacter()
    {
        personajeSeleccionado = (personajeSeleccionado + 1) % personajes.Count;
        switch (personajeSeleccionado)
        {
            case 0:
                SeleccionarPersonaje(astrologoPrefab);
                break;
            case 1:
                SeleccionarPersonaje(miserablePrefab);
                break;
            case 2:
                SeleccionarPersonaje(confesorPrefab);
                break;
            case 3:
                SeleccionarPersonaje(bandidoPrefab);
                break;
        }
    }

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
