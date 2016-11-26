using UnityEngine;
using System.Collections;

public class MoveCircleK : MonoBehaviour {

    public static bool movingFlag = true;
    GameObject testing;

    void Start()
    {
        testing = GameObject.Find("Cursor");
    }

    // Update is called once per frame
    void Update()
    {
        if (movingFlag)
        {
            if (TimeToMoveCircleK.MoveTheObjK)
            {
                this.gameObject.transform.position = testing.transform.position;
                MoveRectK.movingFlag = false;
                MoveTriK.movingFlag = false;
            }
        }

    }
}
