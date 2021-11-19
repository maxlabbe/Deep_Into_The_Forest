using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowButtonSelectionResponse : MonoBehaviour, ISelectionResponse
{
    public Inventory inventory;
    //The time to hold the button to pick an object
    [SerializeField]
    private float m_pickedUpTime = 2f;

    //The current time which the player is holding the button
    [SerializeField]
    private float m_currentPickedUpTimerElapsed = 0f;

    //The behavior when an object is selected
    public void OnSelect(Transform selectedObject)
    {
        //get the transform of the child object which has the canvas that shox the button to press
        Transform buttonCanvasTransform = selectedObject.GetChild(0);

        if (buttonCanvasTransform != null)
        {
            //Get the child object
            GameObject buttonCanvas = buttonCanvasTransform.gameObject;

            //Set the child object active
            buttonCanvas.SetActive(true);

            //Call the activate button function
            ActiveButton(selectedObject);

            //Normalized the pick up time to call the function that fill the image on the selected object
            float pct = m_currentPickedUpTimerElapsed / m_pickedUpTime;

            var imageEvents = buttonCanvas.GetComponent<ImageEvent>();

            if (imageEvents != null)
            {
                imageEvents.updatePickUpProgressImage(pct);
            }
        }
    }

    //The behavior when an object is deselected
    public void OnDeselect(Transform selectedObject)
    {
        if(selectedObject != null)
        {
            //Get the transform of the child of the selected object
            Transform buttonCanvasTransform = selectedObject.GetChild(0);

            if (buttonCanvasTransform != null)
            {
                //Select the child of the selected object 
                GameObject buttonCanvas = buttonCanvasTransform.gameObject;

                //deactivate the child (don't show the button when not looking)
                buttonCanvas.SetActive(false);
            }

            //Put the time that the player hold the button to 0
            m_currentPickedUpTimerElapsed = 0f;
        }
    }

    private void ActiveButton(Transform selectedObject)
    {
        if (Input.GetButton("Fire1"))
        {
            //When the button is press, call the function to pick up the object
            IncrementPickedupProgressAndTryComplete(selectedObject);
        }
        else
        {
            //if the button is unpress put the press time to 0
            m_currentPickedUpTimerElapsed = 0f;
        }
    }

    private void IncrementPickedupProgressAndTryComplete(Transform selectedObject)
    {
        //Increse the time when the button is pressed
        m_currentPickedUpTimerElapsed += Time.deltaTime;

        //if the time is over the amount of time to complete the action then it calls the action to do with the object
        if(m_currentPickedUpTimerElapsed > m_pickedUpTime)
        {
            //the action to do with the object
            DoSomethingWithItem(selectedObject);
            OnDeselect(selectedObject);
        }
    }

    private void DoSomethingWithItem(Transform selectedObject)
    {
        if(selectedObject.gameObject.tag == "Camp")
        {
            float lifeTimeOfCamp = 2f;
            StartCoroutine(ItemIsCamp(selectedObject, lifeTimeOfCamp));
        }

        else
        {
            inventory.AddObjectToInventory(selectedObject.gameObject);
            //destroy the object
            if (selectedObject.gameObject.tag != "water")
            {
                Destroy(selectedObject.gameObject);
            }
        }
    }

    IEnumerator ItemIsCamp(Transform selectedObject, float lifeTimeOfCamp)
    {
        inventory.UseCamp();

        GameObject tent = selectedObject.gameObject;
        //Get the transform of the child of the selected object
        Transform buttonCanvasTransform = selectedObject.GetChild(0);

        //Select the child of the selected object 
        GameObject buttonCanvas = buttonCanvasTransform.gameObject;
        Destroy(buttonCanvas);
        yield return new WaitForSecondsRealtime(lifeTimeOfCamp);
        Destroy(tent);
    }
}
