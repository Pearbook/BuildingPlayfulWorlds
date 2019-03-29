using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntitieTrigger : MonoBehaviour
{
    public EntitieController Controller;

    private bool isActivated;

    private void OnTriggerEnter(Collider other)
    {
        if (!isActivated)
        {
            isActivated = true;

            Controller.EnableEntitie();
        }
    }
}
