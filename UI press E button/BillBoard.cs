using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Fait en sorte que l'affichage du E pointe toujours vers la caméra
public class BillBoard : MonoBehaviour
{
    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(transform.position + Camera.main.transform.forward);
    }
}
