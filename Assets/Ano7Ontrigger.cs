using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ano7Ontrigger : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource;

    private void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        audioSource.Stop();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("closed", true);
            audioSource.Play();
        }
    }

    
}

