using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaHUD : MonoBehaviour
{
    public Player jogador;
    private int totalCoracoes;
    public Sprite cCheio, cVazio;
    public Image[] coracao = new Image[3];

    private void Update()
    {
        totalCoracoes = jogador.vidaPlayer;
        if (totalCoracoes < 3)
        {
            coracao[2].sprite = cVazio;

            if (totalCoracoes < 2)
            {
                coracao[1].sprite = cVazio;

                if(totalCoracoes < 1)
                {
                    coracao[0].sprite = cVazio;
                }
            }
        }


    }
}
