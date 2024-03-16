using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartPusher : MonoBehaviour
{
    private GameObject[] carts;

    private int randomNumber;

    [SerializeField] private AudioClip cartPushSound;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {        
        carts = GameObject.FindGameObjectsWithTag("Cart");

        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(cartPushSound);

        for (int i = 0; i < carts.Length; i++)
        {
            randomNumber = Random.Range(500, 1000);
            carts[i].GetComponent<Rigidbody>().AddForce(randomNumber, 0, randomNumber);
        }  

        Destroy(this.gameObject, 2.0f);
    }
}
