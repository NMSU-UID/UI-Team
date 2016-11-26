using UnityEngine;
using System.Collections;

public class StopTri : MonoBehaviour
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

        if (!TimeToStopTri.checkPos && handGes.GetComponent<GUIText>().text == "v_sign")
        {
            addWrongDrop(TimeToMoveTri.MoveTheObj);
            TimeToMoveTri.MoveTheObj = false;
            MoveCircle.movingFlag = true;
            MoveRect.movingFlag = true;
        }
        else if (TimeToStopTri.checkPos && handGes.GetComponent<GUIText>().text == "v_sign")
        {
            MoveCircle.movingFlag = true;
            MoveRect.movingFlag = true;
            TimeToMoveTri.MoveTheObj = false;
            checkMarkTri.GetComponent<SpriteRenderer>().enabled = true;
            Task3Timer.theTri = true;
        }

    }

    void addWrongDrop(bool a)
    {
        if (objectDroppedOutside && a)
            CounterTask3.theCounter1 += 1;
        objectDroppedOutside = false;
    }
}
