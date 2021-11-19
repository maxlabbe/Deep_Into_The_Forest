using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public SurvivalData m_data;

    [SerializeField]
    private int m_water = 0;

    [SerializeField]
    private int m_food = 0;

    [SerializeField]
    private int m_wood = 0;

    public SpawnCampClick spawnCamp;

    public void AddObjectToInventory(GameObject item)
    {
        if(item.tag == "water")
        {
            AddWater();
        }

        if (item.tag == "mushroom")
        {
            Addfood();
        }

        if (item.tag == "woodStick")
        {
            AddWood();
        }
    }

    public int GetWater()
    {
        return m_water;
    }

    public void SetWater(int quantity)
    {
        m_water += quantity;
    }

    public void AddWater()
    {
        m_water++;
    }

    public int GetFood()
    {
        return m_food;
    }

    public void SetFood(int quantity)
    {
        m_food += quantity;
    }

    public void Addfood()
    {
        m_food++;
    }

    public int GetWood()
    {
        return m_wood;
    }

    public void SetWood(int quantity)
    {
        m_wood += quantity;
    }

    public void AddWood()
    {
        m_wood++;
    }

    public bool UseWater()
    {
        if(m_water > 0)
        {
            m_water--;
            m_data.RemoveThirst();
            m_data.RegainHealth();
            return true;
        }

        return false;
    }

    public bool UseMushroom()
    {
        if(m_food > 0)
        {
            m_food--;
            m_data.RemoveHunger();
            m_data.RegainHealth();
            return true;
        }

        return false;
    }

    public bool UseWood()
    {
        if(m_wood > 0)
        {
            //spawnCamp.SpawnCamp();
            spawnCamp.SpawnCampInFrontOfPLayer();
            m_wood--;
            return true;
        }

        return false;
    }

    public void UseCamp()
    {
        m_data.RemoveSleep();
        m_data.RegainHealth();
    }
}
