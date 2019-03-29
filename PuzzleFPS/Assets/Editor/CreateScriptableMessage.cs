using UnityEngine;
using UnityEditor;

public class CreateScriptableMessage
{
    [MenuItem("Assets/Create/Scriptable Objects/Plant Scriptable")]
    public static void CreateAsset()
    {
        ScriptableObjectUtility.CreateAsset<PlantScriptable>();
    }
}