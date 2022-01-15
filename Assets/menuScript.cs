using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public GameObject panel;

    void Update()
    {

    }
    public void StartButton()
    {
        SceneManager.LoadScene("sideScroll");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
