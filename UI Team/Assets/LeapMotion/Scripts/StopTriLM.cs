using UnityEngine;
using System.Collections;

public class StopTriLM : MonoBehaviour
{
    GameObject checkMarkTri;
    GameObject handGes;
    bool objectDroppedOutside = false;

    // Use this for initialization
    void Start()
    {
        handGes = GameObject.Find("myTextLeft");
        checkMarkTri = GameObject.Find("CheckMarkTriangle");
    }

    // Update is called once per frame
    void Update()
    {
        if (handGes.GetComponent<GUIText>().text != "v_sign")
        {
            objectDroppedOutside = true;
        }

        if (!TimeToStopTriLM.checkPos && handGes.GetComponent<GUIText>().text == "v_sign")
        {
            addWrongDrop(TimeToMoveTriLM.MoveTheObj);
            TimeToMoveTriLM.MoveTheObj = false;
            MoveCircleLM.movingFlag = true;
            MoveRectLM.movingFlag = true;
        }
        else if (TimeToStopTriLM.checkPos && handGes.GetComponent<GUIText>().text == "v_sign")
        {
            MoveCircleLM.movingFlag = true;
            MoveRectLM.movingFlag = true;
            TimeToMoveTriLM.MoveTheObj = false;
            checkMarkTri.GetComponent<SpriteRenderer>().enabled = true;
            Task3Timer.theTri = true;
        }

    }

    void addWrongDrop(bool a)
    {
        if (objectDroppedOutside && a)
            CounterTask3LM.theCounter1 += 1;
        objectDroppedOutside = false;
    }
}
