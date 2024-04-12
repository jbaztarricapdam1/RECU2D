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

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        // Verificar si se presiona la tecla de salto y el personaje está en el suelo.
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Saltar();
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
