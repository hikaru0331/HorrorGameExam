using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderGenerater : MonoBehaviour
{
    [SerializeField] private GameObject spider;
    private int generateSpidersCount = 15;
    private float waitSeconds = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerateSpiders());
        Destroy(this.gameObject, waitSeconds * generateSpidersCount);
    }

    IEnumerator GenerateSpiders()
    {
       for (int i = 0; i < generateSpidersCount; i++)
        {
            Instantiate(spider, new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z), Quaternion.Euler(0, Random.Range(0, 180), 0));
            yield return new WaitForSeconds(waitSeconds);
        }
    }
}
