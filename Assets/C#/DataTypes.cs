using Unity.VisualScripting;
using UnityEngine;

public class DataTypesTest : MonoBehaviour
{
    public string namePerson = "abobus";
    public int result;
    public int spRot = 3;
    public int spM = 8;
    public int jumpPower=3;
    public Transform trans;
    public Vector3 position;
    public Vector3 scale;
    public Quaternion rotation;
    public Rigidbody rbcube;
    public bool isJump;
    public float derection;
    private void Start()
    {
        trans.position = position;
        trans.rotation = rotation;
        trans.localScale = scale;
    }

    private void Update()
    { 
        // trans.position += Vector3.left*spM*Time.deltaTime;
        // trans.rotation *= Quaternion.Euler(0, spRot * Time.deltaTime, 0);
        rbcube.MovePosition(rbcube.position + Vector3.left * spM * Time.deltaTime);
        jumpPower = isJump? 3:0;
        rbcube.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);

    }
    
}
