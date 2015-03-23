using UnityEngine;
using System.Collections;

public class DoorClosed : State { //inherit from State.cs
	
	GameObject target;
    public DoorClosed(GameObject myGameObject, Transform player)
        : base(myGameObject) //At one stage I had debugs for each part of each state, letting me know where things were stuck (if they were)
	{
	
		
	}
	
	public override void Enter ()
	{
		//Debug.Log ("I'm closed!");
        //At one stage I had debugs for each part of each state, letting me know where things were stuck (if they were)
		target = GameObject.FindWithTag("Player");
        //finding player bullet
	}
	public override void Update ()
	{	
		//Debug.Log ("I'm still closed...");
        //At one stage I had debugs for each part of each state, letting me know where things were stuck (if they were)
		
        //when player is in range, move to dooropened state.
        if(Vector3.Distance(myGameObject.transform.position, target.transform.position) < 25)
		{
			myGameObject.GetComponent<StateMachine>().SwitchState(new DoorOpened(myGameObject));//call SwitchState and create a new state for it, passing over the constructor argument
		}
       
	}
	public override void Exit ()
	{
       // Debug.Log("DoorClosed State is Exiting");
		//Debug.Log ("Player detected, proceed to open!");
        //At one stage I had debugs for each part of each state, letting me know where things were stuck (if they were)
	}
}
