using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    ///Variable Declaration/Implementation
    //Public
    public TankView tankView;

    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
    }

    /// <summary>
    /// Tank Class - to make different tanks for the tank spawner
    /// </summary>
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankTypes tankTypes;
        public Material color; //Used to change the tank color
    }

    /// <summary>
    /// Tank List - List of the tanks to pick from with different values
    /// </summary>
    public List<Tank> tankList;

    /// <summary>
    /// CreateTank Function - Function to create the tank prefab that can be called by other scripts
    /// </summary>
    private void CreateTank()
    {
        //Set Tank Model component
        TankModel tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotationSpeed, tankList[0].tankTypes, tankList[0].color);

        //Set Tank Controller component
        TankController tankController = new TankController(tankModel, tankView);
    }
}
