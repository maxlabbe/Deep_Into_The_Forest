using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResponsiveSelector : MonoBehaviour, ISelector
{
    [SerializeField] private List<Transform> m_selectableObjects;
    [SerializeField] private float m_treshold;
    private Transform m_selectedObject;
   public bool Check(Ray ray)
    {
        m_selectedObject = null;

        float closest = 0;
        for(int selectableObjectIndex = 0; selectableObjectIndex < m_selectableObjects.Count; selectableObjectIndex++)
        {
            Vector3 vector1 = ray.direction;
            Vector3 vector2 = m_selectableObjects[selectableObjectIndex].position - ray.origin;

            float lookPurrcentage = Vector3.Dot(vector1.normalized, vector2.normalized);

            if(lookPurrcentage > m_treshold && lookPurrcentage > closest)
            {
                closest = lookPurrcentage;
                m_selectedObject = m_selectableObjects[selectableObjectIndex];
            }

            return true;
        }

        return false;
    }

    public Transform GetSelection()
    {
        return m_selectedObject;
    }
}
