using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionType : MonoBehaviour
{
    public Material m;
    private void OnTriggerEnter(Collider other)
    {
        print("OnTrigEnter");
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        m.color = Color.red;
    }
    private void OnCollisionStay(Collision collision)
    {
        m.color = Color.black;
    }
    private void OnCollisionExit(Collision collision)
    {
        
    }
    private void OnMouseEnter()
    {
        print("OnMouseEnter");
        m.color = Color.green;
    }
    private void OnMouseExit()
    {
        print("OnMouseExit");
        m.color = Color.white;
    }
    private void OnMouseDown()
    {
        print("OnMouseDown");
       m.color = Color.red;
    }
    private void OnMouseUp()
    {
        print("OnMouseUp");
        m.color = Color.yellow;
    }
    private void OnMouseDrag()
    {
        print("OnMouseDrag");
    }
}

