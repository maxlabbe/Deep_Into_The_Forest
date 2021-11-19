using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCampClick : MonoBehaviour
{
    private Ray myRay; // Create the ray
    private RaycastHit hit; //Creating the raycast hit

    public GameObject objectToInstantiate;
    public Transform player;
    
    // Update is called once per frame
    public void SpawnCamp()
    {
        myRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(myRay, out hit))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Instantiate(objectToInstantiate, hit.point, Quaternion.identity);
                }
            }
    }

    public void SpawnCampInFrontOfPLayer()
    {
        float x = player.position.x + 2*player.forward.x;
        float z = player.position.z + 2*player.forward.z;
        float y = player.GetChild(2).position.y;
        Quaternion rotation = player.rotation;
        rotation.y += 90;

        Vector3 spawnPosition = new Vector3(x, y, z);
        Instantiate(objectToInstantiate, spawnPosition, rotation);
    }
}
