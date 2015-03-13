using UnityEngine;
using System.Collections;

public class DoorReCloseLeft : State {

    public DoorReCloseLeft(GameObject myGameObject)
        : base(myGameObject) //constructor that needs the same argument as the State base class constructor. use :base(GameObject) to inherit the same myGameObject reference, so this class can access the gameobject it's refereing to
	{
	
		
	}
    public override void Enter()
    {
        
    }
    public override void Update()
    {
        
        if(myGameObject.transform.position.x < -15f )
        {
            Debug.Log("LEss than 15");
            myGameObject.transform.Translate(Vector3.right * 10 * Time.deltaTime);
        }
        else if (myGameObject.transform.position.x == 0)
        {
            //  myGameObject.transform.position.x ;
        }
        

    }
    public override void Exit()
    {
       
    }
}
