using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemMenu : MonoBehaviour
{
    public Color hoverColor;
    public Color baseColor;
    public Color baseBackgroundColor;
    public Color hoverBackgroundColor;
    public Image middleGroundImage;
    public Image backgroundImage;


    // Start is called before the first frame update
    void Start()
    {
        middleGroundImage.color = baseColor;
        backgroundImage.color = baseBackgroundColor;
    }

    public void Select()
    {
        middleGroundImage.color = hoverColor;
        backgroundImage.color = hoverBackgroundColor;
    }

    public void Deselect()
    {
        middleGroundImage.color = baseColor;
        backgroundImage.color = baseBackgroundColor;
    }
}
