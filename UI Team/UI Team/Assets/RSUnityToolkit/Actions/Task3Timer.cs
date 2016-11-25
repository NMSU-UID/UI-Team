using UnityEngine;
using System.Collections;

public class Task3Timer : MonoBehaviour {

    public static bool theRect = false;
    public static bool theTri = false;
    public static bool theCircle = false;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
	if (theRect && theTri && theCircle)
        {
            SimpleTimer.timeCon = false;
        }
	}
}
