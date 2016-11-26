using UnityEngine;
using System.Collections;

public class StopCircle : MonoBehaviour
{
    GameObject checkMarkCircle;
    GameObject handGes;
    bool objectDroppedOutside = false;

    // Use this for initialization
    void Start()
    {
        handGes = GameObject.Find("myTextLeft");
        checkMarkCircle = GameObject.Find("CheckMarkCircle");
    }

    // Update is called once per frame
    void Update()
    {
        if (handGes.GetComponent<GUIText>().text != "v_sign")
        {
            objectDroppedOutside = true;
        }

        if (!TimeToStopCircle.checkPos && handGes.GetComponent<GUIText>().text == "v_sign")
        {
            addWrongDrop(TimeToMoveCircle.MoveTheObj);
            TimeToMoveCircle.MoveTheObj = false;
            MoveRect.movingFlag = true;
            MoveTri.movingFlag = true;
        }
        else if (TimeToStopCircle.checkPos && handGes.GetComponent<GUIText>().text == "v_sign")
        {
            MoveRect.movingFlag = true;
            MoveTri.movingFlag = true;
            TimeToMoveCircle.MoveTheObj = false;
            checkMarkCircle.GetComponent<SpriteRenderer>().enabled = true;
            Task3Timer.theCircle = true;
        }

    }

    void addWrongDrop(bool a)
    {
        if (objectDroppedOutside && a)
            CounterTask3.theCounter1 += 1;
        objectDroppedOutside = false;
    }
}
