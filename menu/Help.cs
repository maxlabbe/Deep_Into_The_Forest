using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help : MonoBehaviour
{
    public GameObject HelpPage;

    public void SetHelpActive()
    {
        gameObject.SetActive(true);
    }

    public void SetHelpInactive()
    {
        gameObject.SetActive(false);
    }

    public void OpenPage()
    {
        HelpPage.SetActive(true);
    }

    public void ClosePage()
    {
        HelpPage.SetActive(false);
    }
}
