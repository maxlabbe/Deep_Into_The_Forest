using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarsScript : MonoBehaviour
{
    public Slider slider;

    public void SetMaxBar(int max)
    {
        slider.maxValue = max;
        slider.value = max;
    }

    public void SetBar(int bar)
    {
        slider.value = bar;
    }
}
