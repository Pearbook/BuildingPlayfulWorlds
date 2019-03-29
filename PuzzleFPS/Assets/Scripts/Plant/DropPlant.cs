using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPlant : MonoBehaviour
{
    [Header("Timer")]
    [Tooltip("Time in seconds.")]
    public float TimerLimit;

    private float timer;
    private float seconds;

    [Header("Drop")]
    public GameObject MyDrop;
    public GameObject SpawnPositionObj;

    private bool hasDropped;

    void Update()
    {
        if (!hasDropped)
        {
            if (seconds >= TimerLimit)
                DropObj();
            else
                UpdateTimer();
        }
    }

    void DropObj()
    {
        hasDropped = true;

        GameObject obj = (GameObject)Instantiate(MyDrop, SpawnPositionObj.transform.position, Quaternion.identity);
    }

    public void UpdateTimer()
    {
        timer += Time.deltaTime;
        seconds = timer % 60;
    }

}
