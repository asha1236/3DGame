using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CerectorCamera : MonoBehaviour
{
    Transform trCam;
    public Transform trPlayer;
    Vector3 offset;
    Vector3 axis;
    float x;
    float y;
    public float sens=10;
    public float angle=40;
    public float speed=35;
    public float minAngle=-60;
    public float maxAngle=70;
    private void Awake()
    {
        trCam = transform;
    }
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        offset = trCam.position-trPlayer.position;
    }

    // Update is called once per frame
    void Update()
    {
        axis = InputAxise();
    }
    private void LateUpdate()
    {
        Rotate();
        Follou();
    }
    Vector3 InputAxise()
    {
        x += Input.GetAxis("Mouse X")*sens;
        y -= Input.GetAxis("Mouse Y")*sens;
        y = Mathf.Clamp(y, minAngle, maxAngle);
        return new Vector3(y,x,0);
    }
    private void Rotate()
    {
        Quaternion rot = Quaternion.Euler(axis);
        trCam.rotation = Quaternion.Slerp(trCam.rotation,rot,angle*Time.deltaTime);
    }
    private void Follou()
    {
        Vector3 pos = trCam.localRotation * offset + trPlayer.position;
        trCam.position = Vector3.Lerp(trCam.position,pos,speed*Time.deltaTime);
    }
}
