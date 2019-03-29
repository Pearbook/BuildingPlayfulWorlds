using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour
{

    public RenderTexture renderTexture;

    private void Update()
    {
        this.GetComponent<Camera>().targetTexture = renderTexture;
        this.GetComponent<Camera>().Render();
        this.GetComponent<Camera>().targetTexture = null;
    }
}
