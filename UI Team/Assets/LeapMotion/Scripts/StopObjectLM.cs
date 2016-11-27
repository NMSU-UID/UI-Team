using UnityEngine;
using System.Collections;

public class StopObjectLM : MonoBehaviour {

    GameObject handGes;
    bool objectDroppedOutside = false;

    // Use this for initialization
    void Start ()
    {
        handGes = GameObject.Find("myTextLeft");
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(handGes.GetComponent<GUIText>().text != "v_sign")
        {
            objectDroppedOutside = true;
        }

        if (!TimeToStopLM.checkPos && handGes.GetComponent<GUIText>().text == "v_sign")
        {
            addWrongDrop(TimeToMoveLM.MoveTheObj);
            TimeToMoveLM.MoveTheObj = false;
        }
        else if (TimeToStopLM.checkPos && handGes.GetComponent<GUIText>().text == "v_sign")
        {
            TimeToMoveLM.MoveTheObj = false;
            SimpleTimer.timeCon = false;
        }
	
	}

    void addWrongDrop(bool a)
    {
        if(objectDroppedOutside && a)
        CounterLM.theCounter1 += 1;
        objectDroppedOutside = false;
    }

}
