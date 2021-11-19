using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public Inventory inventory;

    private Text m_water;
    private Text m_food;
    private Text m_wood;
    // Start is called before the first frame update
    void Start()
    {
        m_water = transform.GetChild(0).GetChild(1).gameObject.GetComponent<Text>();
        m_food = transform.GetChild(1).GetChild(1).gameObject.GetComponent<Text>();
        m_wood = transform.GetChild(2).GetChild(1).gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(m_water != null)
        {
            m_water.text = inventory.GetWater().ToString();
        }

        if (m_food != null)
        {
            m_food.text = inventory.GetFood().ToString();
        }

        if (m_wood != null)
        {
            m_wood.text = inventory.GetWood().ToString();
        }
    }
}
