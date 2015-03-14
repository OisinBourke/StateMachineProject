using UnityEngine;
using System.Collections;

public class DoorReCloseLeft : State {

    public DoorReCloseLeft(GameObject myGameObject)
        : base(myGameObject) 
        //constructor that needs the same argument as the State base class constructor. use :base(GameObject) to inherit the same myGameObject reference, so this class can access the gameobject it's refereing to
	{
	}
    public override void Enter()
    {
        Debug.Log("DoorReCloseLeft State is active");
    }
    public override void Update()   
    {
        
        if(myGameObject.transform.position.x < -10f )
        {
            myGameObject.transform.Translate(Vector3.right * 10 * Time.deltaTime);
        }
    }
    public override void Exit()
    {
        Debug.Log("DoorReCloseLeft State is Exiting");
    }
}
