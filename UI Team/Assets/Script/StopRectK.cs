using UnityEngine;
using System.Collections;

public class StopRectK : MonoBehaviour {

    GameObject checkMarkRect;
    bool objectDroppedOutside = false;

    // Use this for initialization
    void Start()
    {
        checkMarkRect = GameObject.Find("CheckMarkRect");
    }

    // Update is called once per frame
    void Update()
    {
        if (DetectJoints.state != 4)
        {
            objectDroppedOutside = true;
        }

        if (!TimeToStopRectK.checkPos && DetectJoints.state == 4)
        {
            addWrongDrop(TimeToMoveRectK.MoveTheObjK);
            TimeToMoveRectK.MoveTheObjK = false;
            MoveCircleK.movingFlag = true;
            MoveTriK.movingFlag = true;
        }
        else if (TimeToStopCircleK.checkPos && DetectJoints.state == 4)
        {
            MoveCircleK.movingFlag = true;
            MoveTriK.movingFlag = true;
            TimeToMoveRectK.MoveTheObjK = false;
            checkMarkRect.GetComponent<SpriteRenderer>().enabled = true;
            Task3Timer.theRect = true;
        }

    }

    void addWrongDrop(bool a)
    {
        if (objectDroppedOutside && a)
            CounterTask3K.theCounter1 += 1;
        objectDroppedOutside = false;
    }
}
