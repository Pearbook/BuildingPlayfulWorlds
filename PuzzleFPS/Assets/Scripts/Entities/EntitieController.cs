using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntitieController : MonoBehaviour
{
    public GateBehaviour Gate;

    public void EnableEntitie()
    {
        if (Gate != null)
            Gate.EntitieStart();
    }
}
