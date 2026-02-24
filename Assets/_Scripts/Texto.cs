using TMPro;
using UnityEngine;

public class Texto : MonoBehaviour
{
    private Astrologo astrologo;
    public TextMeshProUGUI nombreText;

    void Start()
    {
        if (astrologo != null && nombreText != null)
        {
            nombreText.text = astrologo.Nombre;
        }
    }

}
