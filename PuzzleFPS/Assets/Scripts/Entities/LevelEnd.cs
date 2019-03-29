using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    public Vector3 Offset;
    public float Radius;
    public LayerMask Mask;

    void Update()
    {
        CheckForPlayer();
    }

    void CheckForPlayer()
    {
        Collider[] coll = Physics.OverlapSphere(transform.position + Offset, Radius, Mask);

        if(coll.Length > 0)
        {
            PlayerManager.Player.DisablePlayer();
            InterfaceManager.UI.OpenUICanvas(InterfaceManager.UI.WinScreen, true);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position + Offset, Radius);
    }
}
