using UnityEngine;
using System.Collections;

public class ShootMagic : MonoBehaviour {

    public GameObject myBullet;

	// Use this for initialization
	void Start () 
    {
        
	}
	
	// Update is called once per frame
	void Update () 
    {
        Shoot();
	
	}
    void Shoot() 
    {
        if(Input.GetMouseButtonDown(0))
        {

            //this was to instantiate it....didnt play well with the state machines., couldnt reference it for some reason
            //GameObject bullet = Instantiate(myBullet, transform.position, transform.rotation) as GameObject;
            //bullet.rigidbody.velocity = transform.TransformDirection(Vector3.forward * 50);

            myBullet = GameObject.FindWithTag("bullet");
            myBullet.transform.position = transform.position;
            myBullet.rigidbody.velocity = transform.TransformDirection(Vector3.forward * 100);
        }

    }

}
