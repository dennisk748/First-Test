using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float turnSpeed;
    [SerializeField] string horizontal;
    [SerializeField] string vertical;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        float playerVerticalInput = Input.GetAxis(vertical);
        float playerHorizontalInput = Input.GetAxis(horizontal);
        if (playerVerticalInput != 0 || playerHorizontalInput != 0)
        {
            // this could also work
            transform.Translate(Vector3.forward * speed * Time.deltaTime * playerVerticalInput);
            //Vector3 move = new Vector3(transform.position.x, transform.position.y, transform.position.z + playerVerticalInput * speed * Time.deltaTime);
            //transform.position = move;
            transform.Rotate(Vector3.up, playerHorizontalInput * Time.deltaTime * turnSpeed);
        }


    }
}
