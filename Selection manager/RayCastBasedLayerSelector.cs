using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastBasedLayerSelector : MonoBehaviour, ISelector
{
    [SerializeField]
    [Tooltip("The layer of the object the player can pick")]
    private LayerMask m_layerMask;

    [SerializeField]
    [Tooltip("The distance you can see the UI")]
    private float m_distance;

    private Transform m_selectedObject;

    public bool Check(Ray ray)
    {
        //Determine which object to select
        m_selectedObject = null;
        if (Physics.Raycast(ray, out RaycastHit hitObject, m_distance, m_layerMask))
        {
            //assign the transform of the hit object to be the selected one
            Transform selectedObject = hitObject.transform;
            m_selectedObject = selectedObject;
            return true;
        }

        return false;
    }

    public Transform GetSelection()
    {
        return m_selectedObject;
    }
}