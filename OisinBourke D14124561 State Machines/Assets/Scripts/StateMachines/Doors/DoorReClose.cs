//once the player moves out of range the doors will close behind them
using UnityEngine;
using System.Collections;

public class DoorReClose : State {

    GameObject target;
    public DoorReClose(GameObject myGameObject)
        : base(myGameObject)
    //this class uses the same argument as the state base constructer so it can access the gameobject it's referring to
	{	
	}   
    public override void Enter()
    {
        target = GameObject.FindWithTag("Player");
        //find player

       // Debug.Log("DoorReClose State is Active");
        //At one stage I had debugs for each part of each state, letting me know where things were stuck (if they were)
    }
    public override void Update()
    {
        //checks if player is out of range, then changes state
        if (myGameObject.transform.position.x > 0f)
        {
            myGameObject.transform.Translate(-Vector3.right * 10 * Time.deltaTime);
        }
    }
    public override void Exit()
    {
       // Debug.Log("DoorReClose State is Exiting");
    }
}
