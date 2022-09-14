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
    /// CreateTank Function - Function to create the tank prefab that can be called by other scripts
    /// </summary>
    private void CreateTank()
    {
        //Set Tank Model component
        TankModel tankModel = new TankModel();

        //Set Tank Controller component
        TankController tankController = new TankController(tankModel, tankView);
    }
}
