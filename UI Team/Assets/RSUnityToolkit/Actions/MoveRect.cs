using UnityEngine;
using System.Collections;

public class MoveRect : MonoBehaviour
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
            if (TimeToMoveRect.MoveTheObj)
            {
                this.gameObject.transform.position = testing.transform.position;
                MoveCircle.movingFlag = false;
                MoveTri.movingFlag = false;
            }
        }

    }
}
