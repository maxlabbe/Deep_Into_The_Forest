using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryMenu : MonoBehaviour
{
    private Vector2 m_normalizedMoussePosition;
    private float m_currentAngle;
    private int m_selection;
    private int m_previousSelection;

    public GameObject[] items;

    private ItemMenu m_itemScript;
    private ItemMenu m_previousItemScript;

    // Update is called once per frame
    void Update()
    {
        m_normalizedMoussePosition = new Vector2(Input.mousePosition.x - Screen.width / 2, Input.mousePosition.y - Screen.height / 2);
        m_currentAngle = Mathf.Atan2(m_normalizedMoussePosition.x, m_normalizedMoussePosition.y) * Mathf.Rad2Deg;

        m_currentAngle = (m_currentAngle + 360) % 360;

        m_selection = (int)m_currentAngle / (360/3);

        if(m_selection != m_previousSelection)
        {
            m_previousItemScript = items[m_previousSelection].GetComponent<ItemMenu>();
            if(m_previousItemScript != null)
            {
                m_previousItemScript.Deselect();
            }

            m_previousSelection = m_selection;

            m_itemScript = items[m_selection].GetComponent<ItemMenu>();
            if (m_itemScript != null)
            {
                m_itemScript.Select();
            }
        }
    }

    public GameObject GetSelectedItem()
    {
        return items[m_selection];
    }

}
