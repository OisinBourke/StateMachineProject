//This script swoops the camera back when transitioning from main menu to main scene.
//It also controls the camera tracking through the doors and back while the menu is idle.

using UnityEngine;
using System.Collections;

public class introCamera : MonoBehaviour {

    //declaring where our camera starts and ends
    public Transform to;
    public Transform from;
    bool myBool = false;

    void Start () 
    {
        StartCoroutine("camMove");//start the camera moving back and forth through the doors
	}
	
	void Update () 
    {
        camZoomTransition();   //waiting for the player to press space, needs to be in update
	}
    
    void nextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);//loads next level
    }
    void camZoomTransition() 
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            myBool = true;//player has pressed space, set to a bool to allow for my camera zoom, otherwise it would only move part of the way
        }
        if(myBool)
        {
            //the two speeds for the rotation and position changes
            float lerpPercent = Time.deltaTime * 50f;
            float lerpPercent2 = Time.deltaTime * 52f;
            //invoke to give the camera time to zoom before loading next level
            Invoke("nextLevel", .35f);
            //do the actual movement
            transform.localRotation = Quaternion.Lerp(to.rotation, from.rotation,lerpPercent);
            transform.localPosition = Vector3.Lerp(to.position,from.position, lerpPercent2);
        }
    }

    IEnumerator camMove() 
    {
        //this coroutine makes the camera zoom back and forth through the doors,
        //at the end it begins itself again. Started in start function
        transform.rigidbody.velocity = transform.TransformDirection(-Vector3.forward * 2);
        yield return new WaitForSeconds(60);
        transform.rigidbody.velocity = transform.TransformDirection(Vector3.forward * 2);
        yield return new WaitForSeconds(60);
        camMove();
    }
   

}
