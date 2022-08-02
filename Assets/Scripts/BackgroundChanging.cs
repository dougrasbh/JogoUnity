using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChanging : MonoBehaviour
{
    // Start is called before the first frame update
    public float duration = 5.0F;
    public Color lerpedColor = Color.white;

    public Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
    }
    
    void Update()
    {
        lerpedColor = Color.Lerp(Color.black, Color.white, Mathf.PingPong(Time.time, 3));
        cam.backgroundColor = lerpedColor;
    }
}
