using UnityEngine;
using System.Collections;

public class resetValues : MonoBehaviour
{

    public void resetTimer()
    {
        Invoke("resetStuff", 3);
    }

    public void resetStuff()
    {
        this.gameObject.GetComponent<Rigidbody>().useGravity = false;
        this.gameObject.GetComponent<PlayerSteering>().enabled = true;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }

}
