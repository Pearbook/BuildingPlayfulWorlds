using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedBehaviour : MonoBehaviour
{
    public float DetectRadius;

    public LayerMask PlotMask;

    public bool IsEraser;

    public PlantScriptable MyPlantType;


    public GameObject ImpactParticle;

    [Header("Timer")]
    [Tooltip("Time in seconds.")]
    public float TimerLimit;

    private float timer;
    private float seconds;

    private void Update()
    {
        if(DetectPlot() != null)
        {
            if (!IsEraser)
            {
                DetectPlot().GetComponent<PlotBehaviour>().GrowPlant(MyPlantType);
                DestroySeed();
            }
            else
                DetectPlot().GetComponent<PlotBehaviour>().RemovePlant();
        }

        if (seconds >= TimerLimit)
            DestroySeed();
        else
            UpdateTimer();
    }

    void DestroySeed()
    {
        GameObject part = (GameObject)Instantiate(ImpactParticle, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

    public void UpdateTimer()
    {
        timer += Time.deltaTime;
        seconds = timer % 60;
    }

    Collider DetectPlot()
    {
        Collider[] coll = Physics.OverlapSphere(transform.position, DetectRadius, PlotMask);

        if(coll.Length > 0)
            return coll[0];

        return null;
    }

    private void OnCollisionEnter(Collision collision)
    {
        DestroySeed();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, DetectRadius);
    }
}
