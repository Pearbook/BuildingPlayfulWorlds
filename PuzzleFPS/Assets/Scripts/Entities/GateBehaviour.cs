using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateBehaviour : MonoBehaviour
{

    public Transform GateLock;
    public Animator MyAnimator;

    public void EntitieStart()
    {
        //this.gameObject.SetActive(false);
        MyAnimator.SetTrigger("OpenGate");
    }

    public void SpawnLockPrefab()
    {
        GameObject obj = (GameObject)Instantiate(Resources.Load("prefab_gateLock"), GateLock.position, Quaternion.identity);
        obj.GetComponent<Rigidbody>().angularVelocity = new Vector3(10, 0, 0);
    }
}
