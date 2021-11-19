using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compass : MonoBehaviour
{
    public RawImage CompassImage;
    public Transform Player;

    // Update is called once per frame
    void Update()
    {
        CompassImage.uvRect = new Rect(Player.localEulerAngles.y / 360, 0, 1, 1);
    }
}
