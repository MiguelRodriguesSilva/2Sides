using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStartGame : MonoBehaviour
{

    public void InicarOJogo()
    {
        SceneManager.LoadScene("Level1");
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }
}
