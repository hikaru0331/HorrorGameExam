using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKnockPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip knockSound;
    AudioSource audioSource;
    
    void Start() 
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(knockSound);
        Destroy(gameObject, 1.0f);
    }
}
