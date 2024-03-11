using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKnockPlayer : SelectRayOutline
{
    [SerializeField] private AudioClip knockSound;
    AudioSource audioSource;
    
    void Start() 
    {
        base.Start();
        audioSource = GetComponent<AudioSource>();
    }

    public override void HitNow()
    {
        base.HitNow();

        if(Input.GetMouseButtonDown(0))
        {
            audioSource.PlayOneShot(knockSound);
        }
    }
}
