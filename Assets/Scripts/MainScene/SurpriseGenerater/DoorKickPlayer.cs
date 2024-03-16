using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKickPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip kickSound;
    AudioSource audioSource;
    
    void Start() 
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(kickSound);
        Destroy(gameObject, 1.0f);
    }
}
