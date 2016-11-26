using UnityEngine;
using System.Collections;

public class StopCircleK : MonoBehaviour {

    GameObject checkMarkCircle;
    bool objectDroppedOutside = false;

    // Use this for initialization
    void Start()
    {
        checkMarkCircle = GameObject.Find("CheckMarkCircle");
    }

    // Update is called once per frame
    void Update()
    {
        if (DetectJoints.state != 4)
        {
            objectDroppedOutside = true;
        }

        if (!TimeToStopCircleK.checkPos && DetectJoints.state == 4)
        {
            addWrongDrop(TimeToMoveCircleK.MoveTheObjK);
            TimeToMoveCircleK.MoveTheObjK = false;
            MoveRectK.movingFlag = true;
            MoveTriK.movingFlag = true;
        }
        else if (TimeToStopCircleK.checkPos && DetectJoints.state == 4)
        {
            MoveRectK.movingFlag = true;
            MoveTriK.movingFlag = true;
            TimeToMoveCircleK.MoveTheObjK = false;
            checkMarkCircle.GetComponent<SpriteRenderer>().enabled = true;
            Task3Timer.theCircle = true;
        }

    }

    void addWrongDrop(bool a)
    {
        if (objectDroppedOutside && a)
            CounterTask3K.theCounter1 += 1;
        objectDroppedOutside = false;
    }
}
