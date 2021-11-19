using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    private IRayProvider m_rayProvider;
    private ISelector m_selector;
    private ISelectionResponse m_selectionResponse;

    private Transform m_currentSelectedObject;

    //Set the value of the selection response interface
    private void Awake()
    {
        //Instanciate all interfaces
        m_rayProvider = GetComponent<IRayProvider>();
        m_selector = GetComponent<ISelector>();
        m_selectionResponse = GetComponent<ISelectionResponse>();
    }

    // Update is called once per frame
    void Update()
    {
        //create a ray from camera that take the mouse position
        Ray ray = m_rayProvider.CreateRay();

        //Determine which object to select
        bool objectIsSelected = m_selector.Check(ray);

        //Deactivate the object
        if (m_currentSelectedObject != null && !objectIsSelected)
        {
            m_selectionResponse.OnDeselect(m_currentSelectedObject);
        }

        //Assign the target object as the current object
        m_currentSelectedObject = m_selector.GetSelection();

        //Activate the object
        if (m_currentSelectedObject != null)
        {
            m_selectionResponse.OnSelect(m_currentSelectedObject);
        }
    }
}