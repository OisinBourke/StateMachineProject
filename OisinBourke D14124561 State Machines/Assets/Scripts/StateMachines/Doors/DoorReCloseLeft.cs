//once the player moves out of range the doors will close behind them
using UnityEngine;
using System.Collections;

public class DoorReCloseLeft : State {

    public DoorReCloseLeft(GameObject myGameObject)
        : base(myGameObject)
    //this class uses the same argument as the state base constructer so it can access the gameobject it's referring to
	{
	}
    public override void Enter()
    {
        //Debug.Log("DoorReCloseLeft State is active");
        //At one stage I had debugs for each part of each state, letting me know where things were stuck (if they were)
    }
    public override void Update()   
    {
        //checks if player is out of range, then changes state
        if(myGameObject.transform.position.x < -10f )
        {
            myGameObject.transform.Translate(Vector3.right * 10 * Time.deltaTime);
        }
    }
    public override void Exit()
    {
        //Debug.Log("DoorReCloseLeft State is Exiting");
        //At one stage I had debugs for each part of each state, letting me know where things were stuck (if they were)
    }
}
