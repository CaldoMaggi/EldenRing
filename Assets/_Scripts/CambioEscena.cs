using UnityEngine;

public class CambioEscena : MonoBehaviour
{
    public void CambiarEscena(string nombreEscena)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("DemoPersonaje");
    }

}
