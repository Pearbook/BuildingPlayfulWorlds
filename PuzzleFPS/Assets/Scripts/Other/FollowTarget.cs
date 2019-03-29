using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform Target;

    public float Damping;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target.position, Damping);
    }
}
