using UnityEngine;
using System.Collections;

public class StopObject : MonoBehaviour {

    GameObject cursor;
    GameObject handGes;
    bool objectDroppedOutside = false;

    // Use this for initialization
    void Start ()
    {
        cursor = GameObject.Find("Cursor");
        handGes = GameObject.Find("myTextLeft");
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(handGes.GetComponent<GUIText>().text != "v_sign")
        {
            objectDroppedOutside = true;
        }

        if (!TimeToStop.checkPos && handGes.GetComponent<GUIText>().text == "v_sign")
        {
            addWrongDrop(TimeToMove.MoveTheObj);
            TimeToMove.MoveTheObj = false;
        }
        else if (TimeToStop.checkPos && handGes.GetComponent<GUIText>().text == "v_sign")
        {
            TimeToMove.MoveTheObj = false;
            SimpleTimer.timeCon = false;
            cursor.GetComponent<FinishRSTask>().enabled = true;
        }	
	}

    void addWrongDrop(bool a)
    {
        if(objectDroppedOutside && a)
        Counter.theCounter1 += 1;
        objectDroppedOutside = false;
    }

}
