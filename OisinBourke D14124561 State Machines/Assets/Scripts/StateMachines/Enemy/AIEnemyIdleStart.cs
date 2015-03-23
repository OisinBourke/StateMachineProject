using UnityEngine;
using System.Collections;

public class AIEnemyIdleStart : State { //inherit from State.cs
	
	GameObject target;
    public AIEnemyIdleStart(GameObject myGameObject, Transform player)
        : base(myGameObject)
    //this class uses the same argument as the state base constructer so it can access the gameobject it's referring to
	{
		
	}
	
	public override void Enter ()
	{
       target = GameObject.FindWithTag("bullet");//find the players projectile, the dragons will be reacting to this
        //Debug.Log("IdleStart");
        //At one stage I had debugs for each part of each state, letting me know where things were stuck (if they were)
	}
	public override void Update ()
	{
        
        if(Vector3.Distance(myGameObject.transform.position, target.transform.position) < 15)
		{
			myGameObject.GetComponent<AIStateMachine>().SwitchState(new AIEnemyDIE(myGameObject));//call SwitchState and create a new state for it, passing over the constructor argument
		}
       
	}
	public override void Exit ()
	{
        //Debug.Log("IdleSTARTExit"); 
        //At one stage I had debugs for each part of each state, letting me know where things were stuck (if they were)
	}
}
