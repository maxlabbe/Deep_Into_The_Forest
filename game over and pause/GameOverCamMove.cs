using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverCamMove : MonoBehaviour
{
    public IStopPlaying stopPlaying;
    public Transform player;
    public Transform targetPosition;
    public float t;
    public float speed;

    private void Awake()
    {
        //Instanciate all interfaces
        stopPlaying = GetComponent<IStopPlaying>();
    }

    private void Start()
    {
        stopPlaying.StopPlaying();
    }

    // Update is called once per frame
    public void Update()
    {
        
        Vector3 camPosition = Camera.main.transform.position;
        Camera.main.transform.LookAt(player, Vector3.up);
        Camera.main.transform.position = Vector3.MoveTowards(camPosition, Vector3.Lerp(camPosition, targetPosition.position, t), speed);
    }
}
