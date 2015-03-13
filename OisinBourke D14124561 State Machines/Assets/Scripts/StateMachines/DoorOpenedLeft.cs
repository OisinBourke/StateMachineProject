using UnityEngine;
using System.Collections;

public class DoorOpenedLeft : State
{ //inherit from state
    GameObject target;
    public DoorOpenedLeft(GameObject myGameObject)
        : base(myGameObject) //constructor that needs the same argument as the State base class constructor. use :base(GameObject) to inherit the same myGameObject reference, so this class can access the gameobject it's refereing to
    {

    }
    public override void Enter() //override runs over the base class abstract method of the same name (abstract methods can't handle functionality, they are only a blueprint)
    {
     //   Debug.Log("I'm gonna open!");
        target = GameObject.FindWithTag("Player");
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

    }
}
