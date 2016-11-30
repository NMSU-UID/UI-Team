using UnityEngine;
using System.Collections;

public class StopRectLM : MonoBehaviour
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

        if (!TimeToStopRectLM.checkPos && handGes.GetComponent<GUIText>().text == "v_sign")
        {
            addWrongDrop(TimeToMoveRectLM.MoveTheObj);
            TimeToMoveRectLM.MoveTheObj = false;
            MoveCircleLM.movingFlag = true;
            MoveTriLM.movingFlag = true;
        }
        else if (TimeToStopRectLM.checkPos && handGes.GetComponent<GUIText>().text == "v_sign")
        {
            MoveCircleLM.movingFlag = true;
            MoveTriLM.movingFlag = true;
            TimeToMoveRectLM.MoveTheObj = false;
            checkMarkRect.GetComponent<SpriteRenderer>().enabled = true;
            Task3TimerLM.theRect = true;
        }

    }

    void addWrongDrop(bool a)
    {
        if (objectDroppedOutside && a)
            CounterTask3LM.theCounter1 += 1;
        objectDroppedOutside = false;
    }
}
