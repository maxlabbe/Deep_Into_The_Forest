using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public Inventory inventory;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            inventory.UseWater();
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            inventory.UseMushroom();
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            inventory.UseWood();
        }
    }
}
