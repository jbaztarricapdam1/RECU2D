using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinchos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Detectar la colisión
    void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si el objeto que colisiona tiene la etiqueta "Player"
        if (other.gameObject.tag == "jugador")
        {
            // Cerrar el juego
            Application.Quit();
            
            // Nota: Esto solo funcionará en una aplicación compilada. 
            // Si estás en el editor de Unity, puedes usar el siguiente código para detener el editor:
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }
    }
}
