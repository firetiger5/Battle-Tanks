using UnityEngine;

public class TankModel
{
    ///Variable Implementation/Declaration
    //Public
    public float movementSpeed; //Used for movement speed
    public float rotationSpeed; //Used for rotation speed

    //Private
    private TankController tankController; //Tank Controller Script Reference


    /// <summary>
    /// Tank Model Constructor - When the object is created this will be called
    /// </summary>
    public TankModel(float _movement, float _rotation)
    {
        //Sets up the variables
        movementSpeed = _movement;
        rotationSpeed = _rotation;
    }

    /// <summary>
    /// Set Tank Controller - Function to set the tank model under tank controller
    /// </summary>
    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
