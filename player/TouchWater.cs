using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchWater : MonoBehaviour
{
    private SurvivalData m_data;
    public Transform waterCheck;
    private float m_groundDistance = 0.1f;
    public LayerMask waterMask;
    private bool m_onWater;


    private void Awake()
    {
        //Instanciate all interfaces
        m_data = GetComponent<SurvivalData>();
    }

    // Update is called once per frame
    void Update()
    {
        m_onWater = Physics.CheckSphere(waterCheck.position, m_groundDistance, waterMask);

        if(m_onWater)
        {
            m_data.HealthDownToZero();
        }
    }
}
