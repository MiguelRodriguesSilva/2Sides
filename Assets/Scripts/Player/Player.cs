using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidadePlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentacaoPlayer();
    }

    void MovimentacaoPlayer()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            transform.Translate(Vector3.right * velocidadePlayer * horizontal * Time.deltaTime);
        }

        if (Input.GetAxisRaw("Vertical") != 0)
        {
            transform.Translate(Vector3.up * velocidadePlayer * vertical * Time.deltaTime);
        }
        
    }
}
