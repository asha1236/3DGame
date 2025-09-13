using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cerector : MonoBehaviour
{
   // private FreeCamera cam;
    private Transform trCam;
    public Rigidbody rb_Person;
   // private PersonAim anim;

    public float currentSpeed = 10f;
    public float jumpForce = 5f;

    private bool isTerra = false;
    private bool isRunning = false;

    private Vector3 directionInput;
    private Vector3 newDirectionMove;
    private Vector3 cameraAxisX;
    private Vector3 cameraAxisZ;

    private void Awake()
    {
       // anim = GetComponent<PersonAim>();
       // cam = FindObjectOfType<FreeCamera>();
        //trCam = cam.transform.GetComponent<Transform>();
        rb_Person=GetComponent<Rigidbody>();
    }
    void Update()
    {
        newDirectionMove = InputAxis();
    }
    private void FixedUpdate()
    {
        MovePerson(newDirectionMove);
    }
    private void MovePerson(Vector3 directionMove)
    {
        isRunning = Input.GetKey(KeyCode.LeftShift);


        float moveSpeed = currentSpeed * (isRunning ? 1 : 0.4f);
        rb_Person.MovePosition(rb_Person.position + directionMove * moveSpeed * Time.deltaTime);

    }
    void Jump()
    {

    }
    Vector3 InputAxis()
    {
        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");
        return new Vector3(X, 0, Z);
    }
}
