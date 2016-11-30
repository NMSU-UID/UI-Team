using UnityEngine;
using System.Collections;

public class StopTriK : MonoBehaviour {

    GameObject checkMarkTri;
    bool objectDroppedOutside = false;

    // Use this for initialization
    void Start()
    {
        checkMarkTri = GameObject.Find("CheckMarkTriangle");
    }

    // Update is called once per frame
    void Update()
    {
        if (DetectJoints.state != 4)
        {
            objectDroppedOutside = true;
        }

        if (!TimeToStopTriK.checkPos && DetectJoints.state == 4)
        {
            addWrongDrop(TimeToMoveTriK.MoveTheObjK);
            TimeToMoveTriK.MoveTheObjK = false;
            MoveCircleK.movingFlag = true;
            MoveRectK.movingFlag = true;
        }
        else if (TimeToStopCircleK.checkPos && DetectJoints.state == 4)
        {
            MoveCircleK.movingFlag = true;
            MoveRectK.movingFlag = true;
            TimeToMoveTriK.MoveTheObjK = false;
            checkMarkTri.GetComponent<SpriteRenderer>().enabled = true;
            Task3TimerK.theTri = true;
        }

    }

    void addWrongDrop(bool a)
    {
        if (objectDroppedOutside && a)
            CounterTask3K.theCounter1 += 1;
        objectDroppedOutside = false;
    }
}
