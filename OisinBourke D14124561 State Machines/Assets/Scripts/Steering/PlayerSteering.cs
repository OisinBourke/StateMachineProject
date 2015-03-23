using UnityEngine;
using System.Collections;
//this script uses the Seek steering method, the dragon scales will follow an invisible "head" object in the game
public class PlayerSteering : MonoBehaviour {

    public float mass = 1f;
    public Vector3 velocity = Vector3.zero;
    public float maxSpeed = 5f;
    public Vector3 force = Vector3.zero;
    public GameObject target;

	void Update () 
    {
        ForceIntegrator();
	}
    void ForceIntegrator()
    {
        //acceleration is calculated by dividing the force by the mass of the object.
        Vector3 accel = force / mass;
        velocity = velocity + accel * Time.deltaTime;
        //velocity is calculated by velocity plys the accel x time.deltatime
        transform.position = transform.position + velocity * Time.deltaTime;
        force = Vector3.zero;//reset the force to stop it incrementing forever
        if(velocity.magnitude > float.Epsilon)//using epsilon is like a safety catch. Smallest possible number.
        {
            transform.forward = -Vector3.Normalize(velocity);//we want our forward direction to always be pointing to our velocity direction(the direction we are facing)
        }
        velocity *= 0.99f;
        force += Seek(target.transform.position);//passing down position of target to the Seek or Flee methods
    }

    //return type here is a vector3
    Vector3 Seek(Vector3 target)//seek is a type of Steering Behaviour
    {
        Vector3 desiredVel = target - transform.position;
        desiredVel.Normalize();
        desiredVel *= maxSpeed * 15;
        return desiredVel - velocity;
    }
   
   }

