using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManipulation : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset1;
    Camera cam;
    [Range(0.0f,1.0f)]
    public float value;
    [Range(0.0f, 1.0f)]
    public float value1;
    [Range(0.0f, 1.0f)]
    public float value2;
    [Range(0.0f, 1.0f)]
    public float value3;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + offset1;
        cam.rect = new Rect(value, value1, value2, value3);
    }
}
