using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerectorAnim : MonoBehaviour
{
    private Animator anim;
    private float switchAngleTurn = 45f;
    bool isRunning;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void PlayPersonAnim(Vector3 m_Input )
    {
        isRunning=Input.GetKey(KeyCode.LeftShift);
        float animationSpeed = isRunning ? 1 : 0.5f;
        if (m_Input.sqrMagnitude > 0)
        {
            anim.SetFloat("x", m_Input.x * animationSpeed,0.2f,Time.deltaTime);
            anim.SetFloat("z", m_Input.z * animationSpeed,0.2f, Time.deltaTime);
        }
        else
        {
            anim.SetFloat("x", 0, 0.2f, Time.deltaTime);
            anim.SetFloat("z", 0, 0.2f, Time.deltaTime);
        }
    }
}
