using UnityEngine;
using System.Collections;

public class DoorClosedLeft : State { //inherit from State.cs

    GameObject target;
    public DoorClosedLeft(GameObject myGameObject, Transform player)
        : base(myGameObject)       //this class uses the same argument as the state base constructer so it can access the gameobject it's referring to
    {
    }
    public override void Enter()
    {
        //Debug.Log("DoorClosedLeft State is Active");
        //At one stage I had debugs for each part of each state, letting me know where things were stuck (if they were)
        target = GameObject.FindWithTag("Player");
        //finding player bullet
    }
    public override void Update()
    {  // Debug.Log("I'm still closed...");

        //when player is in range, move to dooropened state.
        if (Vector3.Distance(myGameObject.transform.position, target.transform.position) < 25)
        {
            myGameObject.GetComponent<StateMachine>().SwitchState(new DoorOpenedLeft(myGameObject));
            //call SwitchState and create a new state for it, passing over the constructor argument
        }
    }
    public override void Exit()
    {
       // Debug.Log("DoorClosedLeft State is Exiting");
       // Debug.Log("Player detected, proceed to open!");
        //At one stage I had debugs for each part of each state, letting me know where things were stuck (if they were)
    }
}
