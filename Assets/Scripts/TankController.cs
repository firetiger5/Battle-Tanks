using UnityEngine;

public class TankController
{
    ///Variable Implementation/Declaration
    //Private
    private TankModel tankModel; //Tank Model Script Reference
    private TankView tankView; //Tank View Script Reference
    private Rigidbody rb; //Rigibody Reference


    /// <summary>
    /// Tank Controller Constructor - When the object is created this will be called
    /// </summary>
    public TankController(TankModel _tankModel, TankView _tankView)
    {
        //Set variables
        tankModel = _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView); //Also instantiate Tank

        //Sets the Rigidbody to the newly made TankView variable
        rb = tankView.GetRigidbody();

        //Set the Tank Model and Tank View Tank Controller references
        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        //Change the color of the tank
        tankView.ChangeColor(tankModel.color);
    }


    /// <summary>
    /// Move - Function to control the movement of the player
    /// </summary>
    public void Move(float movement, float movement_speed)
    {
        rb.velocity = tankView.transform.forward * movement * movement_speed;
    }


    /// <summary>
    /// Rotate - Function to control the rotation of the player
    /// </summary>
    public void Rotation(float rotate, float rotate_speed)
    {
        Vector3 vector = new Vector3(0f, rotate * rotate_speed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    /// <summary>
    /// GetTankModel - Function to get this scripts TankModel to pass it to other scripts
    /// </summary>
    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
