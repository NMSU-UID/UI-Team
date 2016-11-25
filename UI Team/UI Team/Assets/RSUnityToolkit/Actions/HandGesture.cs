using UnityEngine;
using System.Collections;
using RSUnityToolkit;

public class HandGesture : MonoBehaviour {
    PXCMHandData handData;
    PXCMHandData.GestureData gestureData;
    public GUIText myTextLeft;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        handData = SenseToolkitManager.Instance.HandDataOutput;

        if (handData != null)
        {
            handData.Update();
            for (int i = 0; i < handData.QueryFiredGesturesNumber(); i++)
                if (handData.QueryFiredGestureData(i, out gestureData) == pxcmStatus.PXCM_STATUS_NO_ERROR)
                    DisplayGestures(gestureData);
            PXCMHandData.AlertData alertData;
            for (int i = 0; i < handData.QueryFiredAlertsNumber(); i++)
                if (handData.QueryFiredAlertData(i, out alertData) == pxcmStatus.PXCM_STATUS_NO_ERROR)
                    ProcessAlerts(alertData);
        }
    }

    //Display Gestures
    void DisplayGestures(PXCMHandData.GestureData gestureData)
    {

       myTextLeft.text = gestureData.name.ToString();

    }

    //Process Alerts to keep track of hands for Gesture Display
    void ProcessAlerts(PXCMHandData.AlertData alertData)
    {
        myTextLeft.text = "";
    }
}
