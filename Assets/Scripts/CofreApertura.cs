using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofreApertura : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Asegúrate de que el objeto con el que colisiona es el personaje
        if (collision.gameObject.tag == "jugador")
        {
            animator.SetTrigger("estaCerrado");
        }
    }
}
