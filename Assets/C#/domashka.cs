using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class domashka1 : MonoBehaviour
{
    public Material dm1;
    
    private void OnCollisionEnter(Collision collision)
    {
        dm1.color = Color.red;
    }
    private void OnCollisionStay(Collision collision)
    {
        dm1.color = Color.red;
        
    }
    private void OnCollisionExit(Collision collision)
    {
        dm1.color = Color.yellow;
    }
}
