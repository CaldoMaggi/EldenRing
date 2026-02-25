using UnityEngine;

public class EfectoSonoro : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ReproducirSonido();
        }
    }

    void ReproducirSonido()
    {
        src.clip = sfx1;
        src.Play();
    }
}
