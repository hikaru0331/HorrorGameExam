using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RandomSurpriseGenerater : SelectRayOutline
{
    [SerializeField] private GameObject nothingText;
    [SerializeField] private GameObject[] surprises;

    private bool canInstantiate;
    private int randomNumber;

    private void Start() 
    {        
        base.Start();
        canInstantiate = ReturnRandomBool();

        randomNumber = Random.Range(0, surprises.Length);

        if(canInstantiate)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    private bool ReturnRandomBool()
    {
        return Random.Range(0, 2) == 0;
    }

    public override void HitNow()
    {
        base.HitNow();

        if(Input.GetMouseButtonDown(0) && canInstantiate)
        {
            Instantiate(surprises[randomNumber]);
        }
        else if(Input.GetMouseButtonDown(0) && !canInstantiate)
        {
            nothingText.SetActive(true);
        }
    }

    public override void NotHit()
    {
        base.NotHit();
        nothingText.SetActive(false);
    }
        
}
