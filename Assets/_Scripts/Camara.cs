using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform objetivo;
    public Vector3 offset = new Vector3(0, 0, -95);

    void LateUpdate()
    {
        // Buscar al jugador 
        if (objetivo == null)
        {
            GameObject found = GameObject.FindWithTag("Player");
            if (found != null) objetivo = found.transform;
            return;
        }
            transform.position = new Vector3(objetivo.position.x + offset.x, objetivo.position.y + offset.y, -10f); //mover la cámara
    }
}