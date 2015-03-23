using UnityEngine;
using System.Collections;

public class resetButton : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
      //  StartCoroutine("ResetTimer");
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
	
	}
    IEnumerator ResetTimer() 
    {
        yield return new WaitForSeconds(7);
        Application.LoadLevel(Application.loadedLevel);

    }
}
