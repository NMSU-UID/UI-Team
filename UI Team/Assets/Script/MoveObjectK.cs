using UnityEngine;
using System.Collections;

public class MoveObjectK : MonoBehaviour {

    GameObject testing;

    void Start()
    {
        testing = GameObject.Find("Cursor");
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeToMoveK.MoveTheObjK)
        {
            this.gameObject.transform.position = testing.transform.position;
        }

    }
}
