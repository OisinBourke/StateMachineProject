using UnityEngine;
using System.Collections;

public class DoorOpenedLeft : State
{ //inherit from state
    GameObject target;
    public DoorOpenedLeft(GameObject myGameObject)
        : base(myGameObject) //this class uses the same argument as the state base constructer so it can access the gameobject it's referring to
    {

    }
    public override void Enter() //override runs over the base class abstract method of the same name (abstract methods can't handle functionality, they are only a blueprint)
    {
     
        target = GameObject.FindWithTag("Player");
        //locate player

        //Debug.Log("DoorOpenedLeft State is Active");
        //At one stage I had debugs for each part of each state, letting me know where things were stuck (if they were)
        
    }
    public override void Update() //override runs over the base class abstract method of the same name (abstract methods can't handle functionality, they are only a blueprint)
    {
        myGameObject.transform.Translate(-Vector3.right * 10 * Time.deltaTime);
        if (Vector3.Distance(myGameObject.transform.position, target.transform.position) > 55)
        {
            myGameObject.GetComponent<StateMachine>().SwitchState(new DoorReCloseLeft(myGameObject));
            //call SwitchState and create a new state for it, passing over the constructor argument
        }
	}
    
    public override void Exit() //override runs over the base class abstract method of the same name (abstract methods can't handle functionality, they are only a blueprint)
    {
        //Debug.Log("DoorOpenedLeft State is Exiting");
        //At one stage I had debugs for each part of each state, letting me know where things were stuck (if they were)
    }
}
