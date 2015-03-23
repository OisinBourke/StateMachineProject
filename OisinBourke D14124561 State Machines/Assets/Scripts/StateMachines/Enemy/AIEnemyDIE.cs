//this state makes the dragon scales breakup and fall down when hit by a bullet

using UnityEngine;
using System.Collections;

public class AIEnemyDIE : State {
    
    GameObject target;
    public AIEnemyDIE(GameObject myGameObject)
        : base(myGameObject)
    //this class uses the same argument as the state base constructer so it can access the gameobject it's referring to
	{		
	}
	public override void Enter() //override runs over the base class abstract method of the same name (abstract methods can't handle functionality, they are only a blueprint)  (<----You wrote this)
	{
        //Debug.Log("dieEnter");
        //At one stage I had debugs for each part of each state, letting me know where things were stuck (if they were)
		target = GameObject.FindWithTag("bullet");
       //locate players bullet

	}
	public override void Update() //override runs over the base class abstract method of the same name (abstract methods can't handle functionality, they are only a blueprint)
	{
        
        //in this state the dragon scales fall to the ground and stop following the lead
        //they also blow apart slightly with explosion force
        myGameObject.rigidbody.useGravity = true;
        myGameObject.GetComponent<PlayerSteering>().enabled = false;
        myGameObject.GetComponent<BoxCollider>().enabled = true;
        myGameObject.rigidbody.AddExplosionForce(2000,target.transform.position,1000);

        //change to IDLE when bullet is out of range.
        if (Vector3.Distance(myGameObject.transform.position, target.transform.position) > 5)
        {
            myGameObject.GetComponent<AIStateMachine>().SwitchState(new AIEnemyIdle(myGameObject));
            //calling the switchstate for the idle state
            
        }
	}
	public override void Exit() //override runs over the base class abstract method of the same name (abstract methods can't handle functionality, they are only a blueprint)
	{
        //change back the values, gravity etc, this didn't work as well with the Idle state for some reason.
        myGameObject.GetComponent<resetValues>().resetTimer();
        //Debug.Log("dieExit");
        //At one stage I had debugs for each part of each state, letting me know where things were stuck (if they were)
	}
}
