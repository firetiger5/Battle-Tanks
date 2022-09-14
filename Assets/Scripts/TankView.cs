using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    ///Variable Implementation/Declaration
    //Private
    private TankController tankController; //Tank Controller Script Reference

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Set Tank Controller - Function to set the tank model under tank controller
    /// </summary>
    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
