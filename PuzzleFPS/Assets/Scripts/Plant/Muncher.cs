using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muncher : MonoBehaviour
{
    // Check for fruit
    // Move fruit to center, just in case
    // Start animation
    // Delete fruit
    // Do the thing

    [Header("Entitie")]
    public EntitieController Entitie;

    [Header("Animation")]
    public Animator MyAnimator;

    [Header("Check")]
    public Vector3 Offset;
    public float Radius;
    public LayerMask Mask;
    private bool hasFruit;

    private void Update()
    {
        if(!hasFruit)
            CheckForFruit();
    }

    void CheckForFruit()
    {
        Collider[] coll = Physics.OverlapSphere(transform.position + Offset, Radius, Mask);

        if(coll.Length > 0)
        {
            MyAnimator.SetTrigger("Snap");
            Destroy(coll[0].gameObject);

            Entitie.EnableEntitie();

            hasFruit = true;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position + Offset, Radius);
    }
}
