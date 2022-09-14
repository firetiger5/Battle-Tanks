using UnityEngine;

public class TankModel
{
    ///Variable Implementation/Declaration
    //Private
    private TankController tankController; //Tank Controller Script Reference


    /// <summary>
    /// Tank Model Constructor - When the object is created this will be called
    /// </summary>
    public TankModel()
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
