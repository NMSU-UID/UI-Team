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
        }
        else if (TimeToStopRect.checkPos && handGes.GetComponent<GUIText>().text == "v_sign")
        {
            TimeToMoveRect.MoveTheObj = false;
            checkMarkRect.GetComponent<SpriteRenderer>().enabled = true;
            Task3Timer.theRect = true;
        }

    }

    void addWrongDrop(bool a)
    {
        if (objectDroppedOutside && a)
            Counter.theCounter1 += 1;
        objectDroppedOutside = false;
    }
}
