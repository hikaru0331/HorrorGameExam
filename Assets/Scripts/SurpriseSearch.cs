using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SurpriseSearch : MonoBehaviour
{
    List<GameObject> surpriseMarkers = new List<GameObject>();

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("SurpriseMarker"))
        {
            surpriseMarkers.Add(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (GameObject addedMarkers in surpriseMarkers)
            {
                addedMarkers.GetComponent<MeshRenderer>().enabled = true;
            }
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.CompareTag("SurpriseMarker"))
        {
            other.GetComponent<MeshRenderer>().enabled = false;
            surpriseMarkers.Remove(other.gameObject);
        }    
    }
}
