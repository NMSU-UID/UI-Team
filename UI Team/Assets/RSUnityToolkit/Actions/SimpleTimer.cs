using UnityEngine;
using System.Collections;

public class SimpleTimer : MonoBehaviour {

    float targetTime = 0.00f;
    public static bool timeCon = true;
    public GUIText theTimer;
    public GUIText theTime;

    void Start()
    {
        theTime.text = "Timer: ";
    }

    void Update()
    {
        if (timeCon)
        {
            targetTime += Time.deltaTime;

            theTimer.text = targetTime.ToString("00.0");

        }

    }

}