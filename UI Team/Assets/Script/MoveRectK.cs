using UnityEngine;
using System.Collections;

public class MoveRectK : MonoBehaviour {

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
            if (TimeToMoveRectK.MoveTheObjK)
            {
                this.gameObject.transform.position = testing.transform.position;
                MoveCircleK.movingFlag = false;
                MoveTriK.movingFlag = false;
            }
        }

    }
}
