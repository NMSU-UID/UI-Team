using UnityEngine;
using System.Collections;

public class MoveTriK : MonoBehaviour
{

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
            if (TimeToMoveTriK.MoveTheObjK)
            {
                this.gameObject.transform.position = testing.transform.position;
                MoveRectK.movingFlag = false;
                MoveCircleK.movingFlag = false;
            }
        }

    }
}
