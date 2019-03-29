using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public float Speed;

    public bool yRotate;

    // Update is called once per frame
    void Update()
    {
        if(!yRotate)
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, transform.localEulerAngles.z - Speed * Time.deltaTime);
        else
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y - Speed * Time.deltaTime, transform.localEulerAngles.z);
    }
}
