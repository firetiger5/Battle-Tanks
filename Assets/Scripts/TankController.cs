using UnityEngine;

public class TankController
{
    ///Variable Implementation/Declaration
    //Private
    private TankModel tankModel; //Tank Model Script Reference
    private TankView tankView; //Tank View Script Reference


    /// <summary>
    /// Tank Controller Constructor - When the object is created this will be called
    /// </summary>
    public TankController(TankModel _tankModel, TankView _tankView)
    {
        //Set variables
        tankModel = _tankModel;
        tankView = _tankView;

        //Set the Tank Model and Tank View Tank Controller references
        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        //Instantaite Tank
        GameObject.Instantiate(tankView.gameObject);
    }

}
