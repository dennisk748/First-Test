using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficSpawner : MonoBehaviour
{
    public GameObject Spawner1;
    public GameObject Spawner2;
    public GameObject[] Vehicles;
    private int randNumber;
    private int time1 = 1000;
    private int time2 = 500;
    private Vector3 spawnPoint1;
    private Vector3 spawnPoint2;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint1 = Spawner1.transform.position;
        spawnPoint2 = Spawner2.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        randNumber = Random.Range(0, 3);

        time1--;
        time2--;
        if (time1 == 0)
        {
            GameObject.Destroy( GameObject.Instantiate(Vehicles[randNumber], spawnPoint1, Spawner1.transform.rotation), 10f);
            time1 = Random.Range(250, 1000);

        }
        else if (time2 == 0)
        {
            GameObject.Destroy(GameObject.Instantiate(Vehicles[randNumber], spawnPoint2, Spawner2.transform.rotation), 10f);
            time2 = Random.Range(1000, 2000);
        }
    
    }
}
