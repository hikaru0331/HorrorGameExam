using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupImpalser : MonoBehaviour
{
    private GameObject[] gameObjects;

    private int randomNumber;

    [SerializeField] private AudioClip crackingSound;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {        
        gameObjects = GameObject.FindGameObjectsWithTag("Cup");

        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(crackingSound);

        for (int i = 0; i < gameObjects.Length; i++)
        {
            randomNumber = Random.Range(10, 31);
            gameObjects[i].GetComponent<Rigidbody>().AddForce(randomNumber, randomNumber * 10, randomNumber);
        }  

        Destroy(this.gameObject, 1.0f);
    }

}
