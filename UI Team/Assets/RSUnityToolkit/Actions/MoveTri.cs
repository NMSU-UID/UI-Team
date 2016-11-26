using UnityEngine;
using System.Collections;

public class MoveTri : MonoBehaviour
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
            if (TimeToMoveTri.MoveTheObj)
            {
                this.gameObject.transform.position = testing.transform.position;
                MoveRect.movingFlag = false;
                MoveCircle.movingFlag = false;
            }
        }

    }
}
