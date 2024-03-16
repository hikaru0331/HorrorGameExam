using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderGenerater : SelectRayOutline
{
    [SerializeField] private GameObject spider;

    public override void HitNow()
    {
        base.HitNow();

        if(Input.GetMouseButtonDown(0))
        {
            StartCoroutine(GenerateSpiders());
        }
    }

    IEnumerator GenerateSpiders()
    {
       for (int i = 0; i < 15; i++)
        {
            Instantiate(spider, new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z), Quaternion.Euler(0, Random.Range(0, 180), 0));
            yield return new WaitForSeconds(0.3f);
        }
    }
}
