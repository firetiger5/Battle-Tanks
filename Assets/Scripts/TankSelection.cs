using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    ///Variable Declaration/Implementation
    //Public
    public TankSpawner tankSpawner; //TankSpawner Reference

    /// <summary>
    /// BlueTankSelected Function - Function to spawn in the Blue tank if the UI is pressed
    /// </summary>
    public void BlueTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.BlueTank);
        gameObject.SetActive(false); //Removes the UI from the screen
    }

    /// <summary>
    /// GreenTankSelected Function - Function to spawn in the Green tank if the UI is pressed
    /// </summary>
    public void GreenTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.GreenTank);
        gameObject.SetActive(false); //Removes the UI from the screen
    }

    /// <summary>
    /// RedTankSelected Function - Function to spawn in the Red tank if the UI is pressed
    /// </summary>
    public void RedTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.RedTank);
        gameObject.SetActive(false); //Removes the UI from the screen
    }
}
