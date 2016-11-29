using UnityEngine;
using System.Collections;

public class MoveTriLM : MonoBehaviour
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
            if (TimeToMoveTriLM.MoveTheObj)
            {
                this.gameObject.transform.position = testing.transform.position;
                MoveRectLM.movingFlag = false;
                MoveCircleLM.movingFlag = false;
            }
        }

    }
}
