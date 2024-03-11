using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyContainer : SelectRayOutline
{
    [SerializeField] private GameObject keyImage;
    [System.NonSerialized] public static bool hasKey;

    public override void HitNow()
    {
        base.HitNow();

        if(Input.GetMouseButtonDown(0))
        {
            hasKey = true;
            keyImage.SetActive(true);
        }
    }
}
