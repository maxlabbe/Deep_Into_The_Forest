using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject MenuButtons;
    public GameObject HowToPlay;
    public GameObject Help;
    public GameObject Credit;

    // Start is called before the first frame update
    void Start()
    {
        MenuButtons.SetActive(true);
        HowToPlay.SetActive(false);
        Help.SetActive(false);
        Credit.SetActive(false);
    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void OpenMenu()
    {
        MenuButtons.SetActive(true);
    }

    public void CloseMenu()
    {
        MenuButtons.SetActive(false);
    }
}
