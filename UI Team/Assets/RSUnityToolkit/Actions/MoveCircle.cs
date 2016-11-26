using UnityEngine;
using System.Collections;

public class MoveCircle : MonoBehaviour
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
            if (TimeToMoveCircle.MoveTheObj)
            {
                this.gameObject.transform.position = testing.transform.position;
                MoveRect.movingFlag = false;
                MoveTri.movingFlag = false;
            }
        }

    }
}
