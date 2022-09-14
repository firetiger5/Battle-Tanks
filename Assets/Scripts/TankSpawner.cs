using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    ///Variable Declaration/Implementation
    //Public
    public GameObject TankPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(TankPrefab, transform.position, Quaternion.identity); //Spawns the tank prefab at this objects position and rotation
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
}
