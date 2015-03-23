using UnityEngine;
using System.Collections;
//This script is the blueprint for the inheriting classes that will control the dragon states, they will all need the functions planned out here
public abstract class AIState {
	
	protected GameObject myGameObject;//only inheriting scripts can access this GameObject
	public AIState(GameObject gameobject) //this constructor assigns the GameObject;
	{
		this.myGameObject = gameobject;
	}
	public abstract void Update(); //all scripts that are inheriting from AIState must have these methods.
	public abstract void Enter();
	public abstract void Exit();
}
