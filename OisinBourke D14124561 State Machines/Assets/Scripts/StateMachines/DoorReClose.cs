using UnityEngine;
using System.Collections;

public class DoorReClose : State {

    GameObject target;
    public DoorReClose(GameObject myGameObject)
        : base(myGameObject) 
        //constructor that needs the same argument as the State base class constructor. use :base(GameObject) to inherit the same myGameObject reference, so this class can access the gameobject it's refereing to
	{
	
		
	}   
    public override void Enter()
    {
        target = GameObject.FindWithTag("Player");  
    }
    public override void Update()
    {
        myGameObject.transform.Translate(-Vector3.right * 10 * Time.deltaTime);

    }
    public override void Exit()
    {

    }
}
