using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomKeyGenerater : MonoBehaviour
{
    private int ramdomNumber;

    // Start is called before the first frame update
    void Awake()
    {
        ramdomNumber = Random.Range(0, this.transform.childCount);

        Transform child = transform.GetChild(ramdomNumber);
        Destroy(child.GetComponent<RandomSurpriseGenerater>());
        child.GetComponent<KeyContainer>().enabled = true;
    }

}
