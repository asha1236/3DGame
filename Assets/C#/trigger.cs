using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public Transform skrimmer;
    private void OnTriggerEnter(Collider other)
    {
        transform.position = new Vector3(14,0,5);
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}