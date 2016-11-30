using UnityEngine;
using System.Collections;

public class StopCircleLM : MonoBehaviour
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

        if (!TimeToStopCircleLM.checkPos && handGes.GetComponent<GUIText>().text == "v_sign")
        {
            addWrongDrop(TimeToMoveCircleLM.MoveTheObj);
            TimeToMoveCircleLM.MoveTheObj = false;
            MoveRectLM.movingFlag = true;
            MoveTriLM.movingFlag = true;
        }
        else if (TimeToStopCircleLM.checkPos && handGes.GetComponent<GUIText>().text == "v_sign")
        {
            MoveRectLM.movingFlag = true;
            MoveTriLM.movingFlag = true;
            TimeToMoveCircleLM.MoveTheObj = false;
            checkMarkCircle.GetComponent<SpriteRenderer>().enabled = true;
            Task3TimerLM.theCircle = true;
        }

    }

    void addWrongDrop(bool a)
    {
        if (objectDroppedOutside && a)
            CounterTask3LM.theCounter1 += 1;
        objectDroppedOutside = false;
    }
}
