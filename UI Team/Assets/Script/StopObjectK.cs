using UnityEngine;
using System.Collections;

public class StopObjectK : MonoBehaviour {

    bool objectDroppedOutside = false;


    // Update is called once per frame
    void Update()
    {
        if (DetectJoints.state != 4)
        {
            objectDroppedOutside = true;
        }

        if (!TimeToStopK.checkPos && DetectJoints.state == 4)
        {
            addWrongDrop(TimeToMoveK.MoveTheObjK);
            TimeToMoveK.MoveTheObjK = false;
        }
        else if (TimeToStopK.checkPos && DetectJoints.state == 4)
        {
            TimeToMoveK.MoveTheObjK = false;
            SimpleTimer.timeCon = false;
        }

    }

    void addWrongDrop(bool a)
    {
        if (objectDroppedOutside && a)
            CounterK.theCounter1 += 1;
        objectDroppedOutside = false;
    }
}
