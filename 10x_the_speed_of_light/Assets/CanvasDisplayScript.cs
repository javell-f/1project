using System.Collections;
using UnityEngine;

public class CanvasDisplayScript : MonoBehaviour
{
    public Canvas canvas;  

    void Start()
    {
        
        Invoke("ShowCanvas", 12f);
    }

    void ShowCanvas()
    {
        
        if (canvas != null)
        {
            canvas.gameObject.SetActive(true);
            Debug.Log("Canvas activated.");
        }
        else
        {
            Debug.LogError("Canvas is null. Make sure to assign the Canvas in the Unity Editor.");
        }
    }
}