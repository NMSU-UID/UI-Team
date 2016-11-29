using UnityEngine;
using System.Collections;

public class MoveRectLM : MonoBehaviour
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
            if (TimeToMoveRectLM.MoveTheObj)
            {
                this.gameObject.transform.position = testing.transform.position;
                MoveCircleLM.movingFlag = false;
                MoveTriLM.movingFlag = false;
            }
        }

    }
}
