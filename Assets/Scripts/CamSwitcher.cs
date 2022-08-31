using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitcher : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("c"))
        {
            Debug.Log("pressed w");
            if (Camera.activeInHierarchy == false)
            {
                mainCamera.SetActive(false);
                Camera.SetActive(true);
            }
            else
            {
                mainCamera.SetActive(true);
                Camera.SetActive(false);
            }

        }
    }
}
