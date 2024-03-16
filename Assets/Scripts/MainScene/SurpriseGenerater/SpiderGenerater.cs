using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderGenerater : MonoBehaviour
{
    [SerializeField] private GameObject spider;
    private int generateSpidersCount = 15;
    private float waitSeconds = 0.3f;

    GameObject player;

    [SerializeField] private AudioClip walkSpiderSound;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        StartCoroutine(GenerateSpiders());
        Destroy(this.gameObject, waitSeconds * generateSpidersCount);

        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(walkSpiderSound);
    }

    IEnumerator GenerateSpiders()
    {
       for (int i = 0; i < generateSpidersCount; i++)
        {
            Instantiate(spider, new Vector3(player.transform.position.x, 0, player.transform.position.z), Quaternion.Euler(0, Random.Range(0, 180), 0));
            yield return new WaitForSeconds(waitSeconds);
        }
    }
}
