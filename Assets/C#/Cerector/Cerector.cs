using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cerector : MonoBehaviour
{
    CerectorAnim anim;
    private Transform trCam;
    public Rigidbody rb_Person;
    // private PersonAim anim;

    public float currentSpeed = 10f;
    public float jumpForce = 5f;
    public float angle = 45f;

    private bool isTerra = false;
    private bool isRunning = false;

    private Vector3 directionInput;
    private Vector3 newDirectionMove;
    private Vector3 cameraAxisX;
    private Vector3 cameraAxisZ;

    private void Awake()
    {
        anim = GetComponent<CerectorAnim>();
        trCam = FindObjectOfType<CerectorCamera>().transform;
        rb_Person = GetComponent<Rigidbody>();
    }
    void Update()
    {
        directionInput = InputAxis();
        GetNewDirection(directionInput);

    }
    private void LateUpdate()
    {
        
        
        anim.PlayPersonAnim(directionInput);
    }
    private void FixedUpdate()
    {
        Rotation();
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
    void GetNewDirection(Vector3 input)
    {
        cameraAxisZ = Vector3.ProjectOnPlane(trCam.forward, Vector3.up);
        cameraAxisX = Vector3.ProjectOnPlane(trCam.right, Vector3.up);
        newDirectionMove = (input.z * cameraAxisZ) + (input.x * cameraAxisX);
    }
    void Rotation()
    {
        Quaternion rotation = Quaternion.LookRotation(cameraAxisZ, Vector3.up);
        Quaternion newRotation = Quaternion.Slerp(rb_Person.rotation, rotation, Time.fixedDeltaTime * angle);
        rb_Person.MoveRotation(newRotation);
    }
    
}
