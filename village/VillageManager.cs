using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillageManager : MonoBehaviour
{
    public GameObject[] villages;
    public float waitTime;

    [SerializeField]
    private int m_villageIndex;
    [SerializeField]
    private int m_currentVillageIndex;

    // Start is called before the first frame update
    void Start()
    {
        ChooseRandomVillageIndex();
        m_currentVillageIndex = m_villageIndex;
        ActivateRandomVillageAtIndex();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(VillageFunction());
    }

    private IEnumerator VillageFunction()
    {
        if(m_villageIndex != m_currentVillageIndex)
        {
            yield return new WaitForSecondsRealtime(waitTime);
            m_currentVillageIndex = m_villageIndex;
            ActivateRandomVillageAtIndex();
            StopAllCoroutines();
        }

        else
        {
            ChooseRandomVillageIndex();
        }
    }

    private void ChooseRandomVillageIndex()
    {
        m_villageIndex = Random.Range(0, villages.Length);
    }

    private void ActivateRandomVillageAtIndex()
    {
        for (int deactivateVillageIndex = 0; deactivateVillageIndex < villages.Length; deactivateVillageIndex++)
        {
            villages[deactivateVillageIndex].SetActive(false);
        }

        villages[m_villageIndex].SetActive(true);
    }

    public int GetVillageIndex()
    {
        return m_villageIndex;
    }
}
