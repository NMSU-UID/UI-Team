using UnityEngine;
using System.Collections;

public class Task3TimerK : MonoBehaviour
{

    public static bool theRect = false;
    public static bool theTri = false;
    public static bool theCircle = false;
    public static GameObject cursor;
    // Use this for initialization
    void Start()
    {
        cursor = GameObject.Find("Cursor");
    }

    // Update is called once per frame
    void Update()
    {
        if (theRect && theTri && theCircle)
        {
            SimpleTimer.timeCon = false;
            cursor.GetComponent<FinishKinectTask>().enabled = true;
        }
    }
}
