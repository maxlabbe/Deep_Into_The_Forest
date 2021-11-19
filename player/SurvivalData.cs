using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivalData : MonoBehaviour
{
    [SerializeField]
    private int m_health;
    [SerializeField]
    private int m_maxHealth;

    [SerializeField]
    private int m_thirst;
    [SerializeField]
    private int m_maxThirst;

    [SerializeField]
    private int m_hunger;
    [SerializeField]
    private int m_maxHunger;

    [SerializeField]
    private int m_sleep;
    [SerializeField]
    private int m_maxSleep;

    private float THSbeginTime;
    private float THSCurrentTime;
    private float HealthBeginTime;
    private float HealthCurrentTime;

    public BarsScript HealthBar;
    public BarsScript ThirstBar;
    public BarsScript HungerBar;
    public BarsScript SleepBar;

    // Start is called before the first frame update
    void Start()
    {
        THSbeginTime = Time.time;
        HealthBeginTime = Time.time;

        m_health = m_maxHealth;
        m_hunger = m_maxHunger;
        m_thirst = m_maxThirst;
        m_sleep = m_maxSleep;

        HealthBar.SetMaxBar(m_health);
        ThirstBar.SetMaxBar(m_thirst);
        HungerBar.SetMaxBar(m_hunger);
        SleepBar.SetMaxBar(m_sleep);
    }

    // Update is called once per frame
    void Update()
    {
        THSCurrentTime = Time.time;
        HealthCurrentTime = Time.time;
        float IntervalTime = THSCurrentTime - THSbeginTime;
        float HealthIntervalTime = HealthCurrentTime - HealthBeginTime;
        if (IntervalTime >= 1f)
        {
            if (m_thirst != 0f)
            {
                m_thirst--;
            }

            if (m_hunger != 0f)
            {
                m_hunger--;
            }

            if (m_sleep != 0f)
            {
                m_sleep--;
            }

            THSbeginTime = Time.time;
        }

        if (m_thirst == 0f || m_hunger == 0f || m_sleep == 0f)
        {
            if(HealthIntervalTime >= 1f)
            {
                if(m_health != 0)
                {
                    m_health--;

                    HealthBeginTime = Time.time;
                }
            }
        }

        ThirstBar.SetBar(m_thirst);
        HungerBar.SetBar(m_hunger);
        SleepBar.SetBar(m_sleep);
        HealthBar.SetBar(m_health);
    }

    public void RegainHealth()
    {
        if(m_health < m_maxHealth)
        {
            m_health += m_maxHealth / 3;

            if (m_health > m_maxHealth)
            {
                m_health = m_maxHealth;
            }
        }
    }

    public void RemoveThirst()
    {
        m_thirst = m_maxThirst;
    }
    public void RemoveHunger()
    {
        m_hunger = m_maxHunger;
    }
    public void RemoveSleep()
    {

        m_sleep = m_maxSleep;
    }

    public int GetHealth()
    {
        return m_health;
    }

    public void HealthDownToZero()
    {
        m_health = 0;
    }
}
