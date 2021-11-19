using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlay : MonoBehaviour
{
    public GameObject HowToPlayPage1;
    public GameObject HowToPlayPage2;

    public void SetHowToPlayActive()
    {
        gameObject.SetActive(true);
    }

    public void SetHowToPlayInactive()
    {
        gameObject.SetActive(false);
    }

    public void OpenPage1()
    {
        HowToPlayPage1.SetActive(true);
    }

    public void OpenPage2()
    {
        HowToPlayPage2.SetActive(true);
    }

    public void ClosePage1()
    {
        HowToPlayPage1.SetActive(false);
    }

    public void ClosePage2()
    {
        HowToPlayPage2.SetActive(false);
    }
}
