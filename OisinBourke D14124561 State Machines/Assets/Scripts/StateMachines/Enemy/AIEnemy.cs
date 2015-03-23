//used to be "doorright"
using UnityEngine;
using System.Collections;

public class AIEnemy : MonoBehaviour {

	void Start () 
	{
		Transform player = GameObject.FindWithTag("bullet").transform;
		this.gameObject.GetComponent<AIStateMachine>().SwitchState(new AIEnemyIdleStart(this.gameObject, player)); 
        //call SwitchState and create a new state for it, passing over the constructor argument
	}
}
