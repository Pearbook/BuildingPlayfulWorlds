using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotBehaviour : MonoBehaviour
{
    public enum type
    {
        None,
        Floor,
        Wall,
        Ceiling
    }

    public type MyOrientation;

    public GameObject WitheredPlant;
    private GameObject PlantedObject;

    private bool hasPlant;

    private PlantScriptable currentPlant;

    public void RemovePlant()
    {
        if (hasPlant)
        {
            Destroy(PlantedObject);
            PlantedObject = null;

            currentPlant = null;
            hasPlant = false;
        }
    }

    public void GrowPlant(PlantScriptable plant)
    {
        if (!hasPlant)
        {
            currentPlant = plant;
            hasPlant = true;

            if (MyOrientation == type.Floor && currentPlant.isFloorPlant)
            {
                PlantedObject = (GameObject)Instantiate(plant.PrefabFloor, transform.position, transform.localRotation);
                PlantedObject.transform.parent = transform;

            }
            else if (MyOrientation == type.Wall && currentPlant.isWallPlant)
            {
                PlantedObject = (GameObject)Instantiate(plant.PrefabWall, transform.position, transform.localRotation);
                PlantedObject.transform.parent = transform;
                PlantedObject.transform.localEulerAngles = new Vector3(0, 0, 90);
            }
            else
            {
                PlantedObject = (GameObject)Instantiate(WitheredPlant, transform.position, transform.localRotation);
                PlantedObject.transform.parent = transform;
                PlantedObject.transform.localEulerAngles = new Vector3(0, 0, 90);
            }

            //PlantedObject.GetComponent<PlantProperties>().myPlot = this.GetComponent<PlotBehaviour>();

            
            
        }
    }
}
