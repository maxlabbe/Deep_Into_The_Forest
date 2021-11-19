using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject cutscene;
    public GameObject gameManager;
    public DesablePause desablePause;

    private void Start()
    {
        cutscene.SetActive(false);
    }
    public void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            gameManager.SetActive(false);
            desablePause.DesablePauseMenu();
            cutscene.SetActive(true);
        }
    }
}
