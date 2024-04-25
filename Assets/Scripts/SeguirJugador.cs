using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    public Transform objetivo;
    public float suavidad = 0.3f;
    public Vector3 offset;

    private void FixedUpdate()
    {
        if (objetivo != null)
        {
            // Calcular la posición a la que la cámara debe moverse.
            Vector3 posicionDeseada = objetivo.position + offset;
            // Interpolar suavemente la posición actual de la cámara hacia la posición deseada.
            Vector3 posicionSuavizada = Vector3.Lerp(transform.position, posicionDeseada, suavidad);
            // Establecer la posición de la cámara.
            transform.position = new Vector3(posicionSuavizada.x, posicionSuavizada.y, transform.position.z);
        }
    }
}
