using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesablePause : MonoBehaviour
{
    public GameObject pauseMenu;
    
    public void DesablePauseMenu()
    {
        pauseMenu.SetActive(false);
    }
}
