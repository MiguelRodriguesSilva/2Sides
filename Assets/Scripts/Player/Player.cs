using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidadePlayer;
    Animator animador;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        animador = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovimentacaoPlayer();
    }

    void MovimentacaoPlayer()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        if (Input.GetAxisRaw("Vertical") != 0)
        {
            transform.Translate(Vector3.up * velocidadePlayer * vertical * Time.deltaTime);
        }
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            transform.Translate(Vector3.right * velocidadePlayer * horizontal * Time.deltaTime);
        }


        if (horizontal != 0)
        {
            animador.SetBool("estaAndando", true);
            animador.SetBool("estaVirado", true);

        }
        else if (vertical != 0)
        {
            if (vertical < 0)
            {
                animador.SetBool("estaAndando", true);
                animador.SetBool("estaVirado", false);
            }
           
        }
        else if (animador.GetBool("estaVirado") == false || vertical == 0 || horizontal == 0)
        {
            animador.SetBool("estaAndando", false);
        }

        

        if (horizontal <= 0 || animador.GetBool("estaVirado") == false)
        {
            sr.flipX = false;
        }
        else if (horizontal > 0)
        {
            sr.flipX = true;
        }


    }

    void Animacao()
    {
        
    }
}
