using UnityEngine;
using System.Collections;

public class MoveObjectLM : MonoBehaviour {

    GameObject testing;

    void Start()
    {
        testing = GameObject.Find("Cursor");
    }

    // Update is called once per frame
    void Update () {
        if(TimeToMoveLM.MoveTheObj)
        {
            this.gameObject.transform.position = testing.transform.position;
        }
	
	}
}
