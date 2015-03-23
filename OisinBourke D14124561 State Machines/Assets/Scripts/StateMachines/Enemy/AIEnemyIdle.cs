using UnityEngine;
using System.Collections;

public class AIEnemyIdle : State
{ //inherit from State.cs

    GameObject target;
    
    public AIEnemyIdle(GameObject myGameObject)
        : base(myGameObject)
    //this class uses the same argument as the state base constructer so it can access the gameobject it's referring to
    {
    }
    public override void Enter()
    {
        //Debug.Log("IdleEnter");
        //At one stage I had debugs for each part of each state, letting me know where things were stuck (if they were)
        target = GameObject.FindWithTag("bullet");
        //find player bulelt
        
    }
    public override void Update()
    {
                
        //if bullet gets within range, change state
        if (Vector3.Distance(myGameObject.transform.position, target.transform.position) < 5)
        {
            myGameObject.GetComponent<AIStateMachine>().SwitchState(new AIEnemyDIE(myGameObject));//call SwitchState and create a new state for it, passing over the constructor argument
        }
    }
    public override void Exit()
    {
        //Debug.Log("IdleExit");
        //At one stage I had debugs for each part of each state, letting me know where things were stuck (if they were)
    }
}