using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparkGenerater : MonoBehaviour
{
    private GameObject[] electroPanels;
    [SerializeField] private AudioClip sparkSound;
    AudioSource audioSource;

    [SerializeField] private GameObject spark;

    // Start is called before the first frame update
    void Start()
    {
        electroPanels = GameObject.FindGameObjectsWithTag("ElectroPanel");

        for (int i = 0; i < electroPanels.Length; i++)
        {
            GameObject generatedSpark = Instantiate(spark, electroPanels[i].transform.position + (Vector3.up * 0.5f), Quaternion.Euler(0, 180, 0));
            Destroy(generatedSpark, 3.0f);
        }

        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sparkSound);

        Destroy(this.gameObject, 3.0f);
    }
}
