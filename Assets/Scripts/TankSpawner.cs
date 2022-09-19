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
    public void CreateTank(TankTypes tankTypes)
    {
        //If-Else statements to spawn in the correct tank
        if (tankTypes == TankTypes.BlueTank)
        {
            //Set Tank Model component
            TankModel tankModel = new TankModel(tankList[1].movementSpeed, tankList[1].rotationSpeed, tankList[1].tankTypes, tankList[1].color);

            //Set Tank Controller component
            TankController tankController = new TankController(tankModel, tankView);
        }

        else if (tankTypes == TankTypes.GreenTank)
        {
            //Set Tank Model component
            TankModel tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotationSpeed, tankList[0].tankTypes, tankList[0].color);

            //Set Tank Controller component
            TankController tankController = new TankController(tankModel, tankView);
        }

        else
        {
            //Set Tank Model component
            TankModel tankModel = new TankModel(tankList[2].movementSpeed, tankList[2].rotationSpeed, tankList[2].tankTypes, tankList[2].color);

            //Set Tank Controller component
            TankController tankController = new TankController(tankModel, tankView);
        }
    }
}
