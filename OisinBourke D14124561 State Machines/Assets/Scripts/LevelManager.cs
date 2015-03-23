using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {


	void Update () 
    {
	    if(Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if (Application.loadedLevel == 0) 
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Application.LoadLevel(Application.loadedLevel + 1);
            }
        }
        if (Application.loadedLevel == 1)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Application.LoadLevel(Application.loadedLevel - 1);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Application.LoadLevel(Application.loadedLevel - 1);
        }

	}
}
