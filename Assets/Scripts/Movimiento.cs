using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidadMovimiento = 5f;
    public float fuerzaSalto = 10f;
    public Transform puntoSuelo;
    public LayerMask capaSuelo;

    private Rigidbody2D rb;

    public int contadorSaltos = 2;
    public int topeSaltos = 2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Verificar si se presiona la tecla de salto y el personaje está en el suelo.
        if (Input.GetKeyDown(KeyCode.UpArrow) && contadorSaltos > 0)
        {
            Saltar();
            contadorSaltos--;

            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1.0f);
            if (hit.collider != null)
            {
                // Si el personaje está en contacto con un objeto debajo de él, igualar el contador al tope de saltos.
                contadorSaltos = topeSaltos;
            }
        }



    }


    void FixedUpdate()
    {
        float direccionMovimiento = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(direccionMovimiento * velocidadMovimiento, rb.velocity.y);
    }

    void Saltar()
    {
        // Aplicar una fuerza vertical al Rigidbody2D para realizar el salto.
        rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        rb.gravityScale = 2f; 
    }
}
