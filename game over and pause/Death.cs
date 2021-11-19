using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public SurvivalData data;
    public IStopPlaying stopPlaying;
    private int m_health;
    public DesablePause desablePause;

    private void Awake()
    {
        //Instanciate all interfaces
        stopPlaying = GetComponent<IStopPlaying>();
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        m_health = data.GetHealth();
        if(m_health == 0)
        {
            desablePause.DesablePauseMenu();
            stopPlaying.StopPlaying();
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
