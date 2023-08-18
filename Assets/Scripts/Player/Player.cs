using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidadePlayer;
    public int vidaBasePlayer = 3;
    public int vidaPlayer;
    Animator animador;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        vidaPlayer = vidaBasePlayer;
        animador = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

    }

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
            if (animador.GetBool("estaVirado") == true)
            {

            }
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
    public void Dano(int danoInimigo)
    {
        vidaPlayer -= danoInimigo;

        if (vidaPlayer < 1)
        {
            vidaPlayer = 0;
            MortePlayer();

        }
    }
    void MortePlayer()
    {
        Debug.Log("To morto");
    }
}