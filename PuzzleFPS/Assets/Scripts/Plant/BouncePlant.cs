using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePlant : MonoBehaviour
{

    public float BounceForce;

    public Vector3 Offset;
    public Vector3 Size;

    public LayerMask PlayerMask;

    [Header("Animation")]
    public Animator MyAnimator;

    private Rigidbody playerBody;

    private void FixedUpdate()
    {
        CheckForPlayer();
    }

    public void CheckForPlayer()
    {
        Collider[] coll = Physics.OverlapBox(transform.position + Offset, new Vector3(Size.x / 2, Size.y / 2, Size.z / 2), Quaternion.identity, PlayerMask);

        if (coll.Length > 0)
        {
            if(coll[0].GetComponent<Rigidbody>() != null)
            {
                coll[0].GetComponent<Rigidbody>().velocity = new Vector3(coll[0].GetComponent<Rigidbody>().velocity.x, BounceForce, coll[0].GetComponent<Rigidbody>().velocity.z);

                MyAnimator.SetTrigger("Bounce");
            }

            /*
            if(playerBody == null)
            {
                playerBody = coll[0].GetComponent<Rigidbody>();
            }
            else
            {
                
                playerBody.velocity = new Vector3(playerBody.velocity.x, BounceForce, playerBody.velocity.z);
            }*/
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(transform.position + Offset, Size);
    }
}
