using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPlayerMovement : MonoBehaviour, IStopPlaying
{
    public Transform player;
    public Animator animator;
    public GameObject uI;
    public GameObject inventory;
    public GameObject mouseLook;
    public GameObject villageManager;
    public void StopPlaying()
    {
        Cursor.lockState = CursorLockMode.Confined;
        uI.SetActive(false);
        player.GetComponent<PlayerMovement>().enabled = false;
        player.GetComponent<PlayerAnimations>().enabled = false;
        player.GetComponent<SurvivalData>().enabled = false;
        mouseLook.SetActive(false);
        inventory.SetActive(false);
        villageManager.SetActive(false);
        animator.SetBool("doNothing", true);
        animator.SetFloat("moveHorizontaly", 0);
        animator.SetFloat("moveVerticaly", 0);
    }

    public void StartPlaying()
    {
        Cursor.lockState = CursorLockMode.Locked;
        uI.SetActive(true);
        player.GetComponent<PlayerMovement>().enabled = true;
        player.GetComponent<PlayerAnimations>().enabled = true;
        player.GetComponent<SurvivalData>().enabled = true;
        mouseLook.SetActive(true);
        inventory.SetActive(true);
        villageManager.SetActive(true);

    }
}
