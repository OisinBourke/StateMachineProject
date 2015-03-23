using UnityEngine;
using System.Collections;
//this script is attached to "head" objects that the dragon segments follow, this head is invisible.
public class EnemySteering : MonoBehaviour {

    public float mass = 1f;
    public Vector3 velocity = Vector3.zero;
    public float maxSpeed = 5f;
    public Vector3 force = Vector3.zero;
    //public GameObject target;
    float timer = 2f, time;
    public Vector3 dest;
	
	void Update () 
    {
        
	    ForceIntegrator();
        time += Time.deltaTime;
        if (time >= timer) 
        {
            dest = new Vector3(Random.Range(50, -50), Random.Range(90, 5), Random.Range(600, 150));
            time = 0;
        }

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
            transform.forward = Vector3.Normalize(velocity);//we want our forward direction to always be pointing to our velocity direction(the direction we are facing)
        }
        velocity *= 0.99f;
        force += Seek(dest);//passing down position of target to the Seek or Flee methods
    }

    Vector3 Seek(Vector3 target)//seek is a type of Steering Behaviour
    {
        Vector3 desiredVel = target - transform.position;
        desiredVel.Normalize();
        desiredVel *= maxSpeed * 30;
        return desiredVel - velocity;
    }
}
