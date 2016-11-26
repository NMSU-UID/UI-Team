using UnityEngine;
using System.Collections;

public class StopRect : MonoBehaviour
{
    GameObject checkMarkRect;
    GameObject handGes;
    bool objectDroppedOutside = false;

    // Use this for initialization
    void Start()
    {
        handGes = GameObject.Find("myTextLeft");
        checkMarkRect = GameObject.Find("CheckMarkRect");
    }

    // Update is called once per frame
    void Update()
    {
        if (handGes.GetComponent<GUIText>().text != "v_sign")
        {
            objectDroppedOutside = true;
        }

        if (!TimeToStopRect.checkPos && handGes.GetComponent<GUIText>().text == "v_sign")
        {
            addWrongDrop(TimeToMoveRect.MoveTheObj);
            TimeToMoveRect.MoveTheObj = false;
            MoveCircle.movingFlag = true;
            MoveTri.movingFlag = true;
        }
        else if (TimeToStopRect.checkPos && handGes.GetComponent<GUIText>().text == "v_sign")
        {
            MoveCircle.movingFlag = true;
            MoveTri.movingFlag = true;
            TimeToMoveRect.MoveTheObj = false;
            checkMarkRect.GetComponent<SpriteRenderer>().enabled = true;
            Task3Timer.theRect = true;
        }

    }

    void addWrongDrop(bool a)
    {
        if (objectDroppedOutside && a)
            CounterTask3.theCounter1 += 1;
        objectDroppedOutside = false;
    }
}
