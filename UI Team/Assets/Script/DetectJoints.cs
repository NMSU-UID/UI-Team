﻿using UnityEngine;
using System.Collections;
using Windows.Kinect;

public class DetectJoints : MonoBehaviour {

    public GameObject BodySrcManager;
    public JointType TrackedJoint;
    private BodySourceManager bodyManager;
    private Body[] bodies;
    public float multiplier = 10f;
    public static int state = 0;

	// Use this for initialization
	void Start () {

        if (BodySrcManager == null)
        {
            Debug.Log("Asign Game Object with Body Source Manager");
        }
        else
        {
            bodyManager = BodySrcManager.GetComponent<BodySourceManager>();
        }
	}
	
	// Update is called once per frame
	void Update () {
	
        if(BodySrcManager == null)
        {
            return;
        }

        bodies = bodyManager.GetData();
        if(bodies == null)
        {
            return;
        }
        foreach (var body in bodies)
        {
            if(body == null)
            {
                continue;
            }
            if (body.IsTracked)
            {

                //state = (int) body.TrackingId;
                state = (int) body.HandRightState;
                var pos = body.Joints[TrackedJoint].Position;
                gameObject.transform.position = new Vector3(pos.X * multiplier, pos.Y*multiplier);

            }
        }
	}
    /*

    private int CheckRightHandState(HandState handState2)
    {
        int result = 0;
        switch (handState2)
        {
            //Normal
            case HandState.Closed:
                result = 0;
                break;
            //Stop
            case HandState.Open:
                result = 0;
                break;
            //Flip
            case HandState.Lasso:
                result = 1;
                break;
            default:
                result = 0;
                break;
        }
        return result;
    }*/
}
