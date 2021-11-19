using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageEvent : MonoBehaviour
{
    //The image we want to fill
    private Image pickUpProgressImage;

    private void Awake()
    {
        //Instanciate the image in the canvas children
        pickUpProgressImage = gameObject.transform.GetChild(0).GetComponent<Image>();
    }
    public void updatePickUpProgressImage(float fillAmount)
    {
        //fill the image at the amount in the parameters
        pickUpProgressImage.fillAmount = fillAmount;
    }
}
