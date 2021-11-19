using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillageSound : MonoBehaviour
{
    public VillageManager villageManager;
    public GameObject villageSound;

    [SerializeField]
    private int m_villageIndex;
    [SerializeField]
    private int m_currentVillageIndex;
    // Start is called before the first frame update
    void Start()
    {
        villageSound.SetActive(false);
        m_villageIndex = villageManager.GetVillageIndex();
        m_currentVillageIndex = villageManager.GetVillageIndex();
    }

    // Update is called once per frame
    void Update()
    {
        m_villageIndex = villageManager.GetVillageIndex();
        if(m_villageIndex != m_currentVillageIndex)
        {
            StartCoroutine(ActiveVillageSound());
            m_currentVillageIndex = m_villageIndex;
        }
    }

    private IEnumerator ActiveVillageSound()
    {
        AudioSource[] sounds = villageSound.GetComponents<AudioSource>();
        villageSound.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        float volume = sounds[0].volume;
        for(float volumeIndex = 0; volumeIndex < volume; volumeIndex+=0.1f)
        {
            for (int soundIndex = 0; soundIndex < sounds.Length; soundIndex++)
            {
                sounds[soundIndex].volume = sounds[soundIndex].volume - 0.1f;
            }
            yield return new WaitForSeconds(0.5f);
        }

        villageSound.SetActive(false);

        for (float volumeIndex = 0; volumeIndex < volume; volumeIndex += 0.1f)
        {
            for (int soundIndex = 0; soundIndex < sounds.Length; soundIndex++)
            {
                sounds[soundIndex].volume = sounds[soundIndex].volume + 0.1f;
            }
        }
        StopAllCoroutines();
    }
}
