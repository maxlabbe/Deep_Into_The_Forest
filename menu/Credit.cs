using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit : MonoBehaviour
{
    public GameObject credit;
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject page4;
    public GameObject page5;
    public void SetCreditActive()
    {
        gameObject.SetActive(true);
    }

    public void SetCreditInactive()
    {
        gameObject.SetActive(false);
    }

    public void OpenPage1()
    {
        page1.SetActive(true);
    }

    public void OpenPage2()
    {
        page2.SetActive(true);
    }

    public void OpenPage3()
    {
        page3.SetActive(true);
    }

    public void OpenPage4()
    {
        page4.SetActive(true);
    }

    public void OpenPage5()
    {
        page5.SetActive(true);
    }

    public void ClosePage1()
    {
        page1.SetActive(false);
    }

    public void ClosePage2()
    {
        page2.SetActive(false);
    }

    public void ClosePage3()
    {
        page3.SetActive(false);
    }

    public void ClosePage4()
    {
        page4.SetActive(false);
    }

    public void ClosePage5()
    {
        page5.SetActive(false);
    }
}
