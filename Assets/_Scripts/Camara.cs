using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform objetivo;
    public Vector3 offset = new Vector3(-2, 0, -1);

    void LateUpdate()
    {
        // 1. Buscar al jugador si se perdió
        if (objetivo == null)
        {
            GameObject found = GameObject.FindWithTag("Player");
            if (found != null) objetivo = found.transform;
            return;
        }

        // 2. MOVER LA CÁMARA (Esto es lo que te faltaba)
        // La cámara se posiciona exactamente a la distancia del offset
        transform.position = objetivo.position + offset;

        // 3. ROTAR LA CÁMARA
        // Ahora que ya está en posición, mira al objetivo
        transform.LookAt(objetivo.position);
    }
}