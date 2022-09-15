using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    ///Variable Implementation/Declaration
    //Public
    public Rigidbody rb; //Rigibody Reference

    //Private
    private TankController tankController; //Tank Controller Script Reference
    private float movement; //Used for movement speed
    private float rotation; //Used for rotation speed


    // Start is called before the first frame update
    void Start()
    {
        //Sets the camera to a variable reference
        GameObject cam = GameObject.Find("Main Camera");

        //Make the camera a child of the spawned tank then give it some offset
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 3.5f, -4f);
    }


    // Update is called once per frame
    void Update()
    {
        Movement(); //Calls the movement function

        //If statement to make sure tank moves only if the correct keys are pressed
        if (movement != 0)
            tankController.Move(movement, tankController.GetTankModel().movementSpeed);

        //If statement to make sure tank rotates only if the correct keys are pressed
        if (rotation != 0)
            tankController.Rotation(rotation, tankController.GetTankModel().rotationSpeed);
    }


    /// <summary>
    /// Movement - Function used to control movement speed and direction
    /// </summary>
    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }


    /// <summary>
    /// Set Tank Controller - Function to set the tank model under tank controller
    /// </summary>
    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

    /// <summary>
    /// GetRigidbody - Function to get this scripts Rigidbody to pass it to other scripts
    /// </summary>
    public Rigidbody GetRigidbody()
    {
        return rb;
    }
}
