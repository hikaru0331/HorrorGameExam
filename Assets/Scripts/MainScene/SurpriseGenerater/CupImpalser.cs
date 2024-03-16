using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupImpalser : MonoBehaviour
{
    private GameObject[] cups;

    private int randomNumber;

    [SerializeField] private AudioClip crackingSound;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {        
        cups = GameObject.FindGameObjectsWithTag("Cup");

        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(crackingSound);

        for (int i = 0; i < cups.Length; i++)
        {
            randomNumber = Random.Range(10, 31);
            cups[i].GetComponent<Rigidbody>().AddForce(randomNumber, randomNumber * 10, randomNumber);
        }  

        Destroy(this.gameObject, 1.0f);
    }

}
