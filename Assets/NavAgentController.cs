using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavAgentController : MonoBehaviour
{
    public Transform m_Destination;
    private NavMeshAgent m_NavAgent;
    public Animator animator;
    public AudioSource audioSource;

    void Start()
    {
        m_NavAgent = GetComponent<NavMeshAgent>();
        if (m_Destination != null && m_NavAgent != null)
        {
            m_NavAgent.SetDestination(m_Destination.position);
        }
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        float speed = m_NavAgent.velocity.magnitude / m_NavAgent.speed;
        if (animator != null)
        {
            animator.SetFloat("moveSpeed", speed);
        }

        if (audioSource != null)
        {
            if (speed > 0 && !audioSource.isPlaying)
            {
                audioSource.Play();
            }
            else if (speed == 0 && audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
