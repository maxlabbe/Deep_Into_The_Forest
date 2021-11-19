using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    public AudioSource audio;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    private bool m_isGrounded;

    [SerializeField]
    private bool m_isPlaying;

    private void Start()
    {
        audio.Pause();
        m_isPlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
        m_isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if (x == 0f && z == 0f || !m_isGrounded)
        {
            m_isPlaying = false;
        }

        else
        {
            m_isPlaying = true;
        }

        if (!m_isPlaying)
        {
            audio.Play();
        }
        
    }
}
