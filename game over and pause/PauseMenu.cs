using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private IStopPlaying m_stopPlaying;
    private bool m_isActive;
    public GameObject menuPause;

    private void Awake()
    {
        //Instanciate all interfaces
        m_stopPlaying = GetComponent<IStopPlaying>();
    }

    // Start is called before the first frame update
    void Start()
    {
        menuPause.SetActive(false);
        m_isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (!m_isActive)
            {
                menuPause.SetActive(true);
                m_stopPlaying.StopPlaying();
                menuPause.SetActive(true);
            }

            else
            {
                m_stopPlaying.StartPlaying();
                menuPause.SetActive(false);
            }

            if (!m_isActive)
            {
                m_isActive = true;
            }

            else
            {
                m_isActive = false;
            }
        }
    }

    public void SetIsActiveAtFalse()
    {
        m_isActive = false;
    }
}
