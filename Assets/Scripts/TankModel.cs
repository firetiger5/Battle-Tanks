using UnityEngine;

public class TankModel
{
    ///Variable Implementation/Declaration
    //Public
    public float movementSpeed; //Used for movement speed
    public float rotationSpeed; //Used for rotation speed
    public TankTypes tankType;
    public Material color;

    //Private
    private TankController tankController; //Tank Controller Script Reference


    /// <summary>
    /// Tank Model Constructor - When the object is created this will be called
    /// </summary>
    public TankModel(float _movement, float _rotation, TankTypes _tank, Material _color)
    {
        //Sets up the variables
        movementSpeed = _movement;
        rotationSpeed = _rotation;
        tankType = _tank;
        color = _color;
    }

    /// <summary>
    /// Set Tank Controller - Function to set the tank model under tank controller
    /// </summary>
    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
