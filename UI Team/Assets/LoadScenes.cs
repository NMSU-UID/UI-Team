using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadScenes : MonoBehaviour {

    public void RealSenseMenu()
    {
        Application.LoadLevel("RealSense Menu");
    }

    public void RealSense1()
    {
        Counter.theCounter1 = 0;
        SimpleTimer.targetTime = 0.00f;
        SimpleTimer.timeCon = true;
        TimeToStop.checkPos = false;
        Application.LoadLevel("RS-Task1");
    }

    public void RealSense2()
    {
        Counter.theCounter1 = 0;
        SimpleTimer.targetTime = 0.00f;
        SimpleTimer.timeCon = true;
        TimeToStop.checkPos = false;
        Application.LoadLevel("RS-Task2");
    }

    public void RealSense3()
    {
        CounterTask3.theCounter1 = 0;
        SimpleTimer.targetTime = 0.00f;
        Task3Timer.theCircle = false;
        Task3Timer.theRect = false;
        Task3Timer.theTri = false;
        SimpleTimer.timeCon = true;
        TimeToStopCircle.checkPos = false;
        TimeToStopTri.checkPos = false;
        TimeToStopRect.checkPos = false;
        Application.LoadLevel("RS-Task3");
    }

    public void LeapMotionMenu()
    {
        Application.LoadLevel("Leap Motion Menu");
    }

    public void LeapMotion1()
    {
        CounterLM.theCounter1 = 0;
        SimpleTimer.targetTime = 0.00f;
        SimpleTimer.timeCon = true;
        TimeToStopLM.checkPos = false;
        Application.LoadLevel("LM-Task1");
    }

    public void LeapMotion2()
    {
        CounterLM.theCounter1 = 0;
        SimpleTimer.targetTime = 0.00f;
        SimpleTimer.timeCon = true;
        TimeToStopLM.checkPos = false;
        Application.LoadLevel("LM-Task2");
    }

    public void LeapMotion3()
    {
        CounterTask3LM.theCounter1 = 0;
        SimpleTimer.targetTime = 0.00f;
        Task3TimerLM.theCircle = false;
        Task3TimerLM.theRect = false;
        Task3TimerLM.theTri = false;
        SimpleTimer.timeCon = true;
        TimeToStopCircleLM.checkPos = false;
        TimeToStopTriLM.checkPos = false;
        TimeToStopRectLM.checkPos = false;
        Application.LoadLevel("LM-Task3");
    }

    public void KinectMenu()
    {
        Application.LoadLevel("Kinect Menu");
    }

    public void Kinect1()
    {
        CounterK.theCounter1 = 0;
        SimpleTimer.targetTime = 0.00f;
        SimpleTimer.timeCon = true;
        TimeToStopK.checkPos = false;
        Application.LoadLevel("Kinect-Task1");
    }

    public void Kinect2()
    {
        CounterK.theCounter1 = 0;
        SimpleTimer.targetTime = 0.00f;
        SimpleTimer.timeCon = true;
        TimeToStopK.checkPos = false;
        Application.LoadLevel("Kinect-Task2");
    }

    public void Kinect3()
    {
        CounterTask3K.theCounter1 = 0;
        SimpleTimer.targetTime = 0.00f;
        Task3TimerK.theCircle = false;
        Task3TimerK.theRect = false;
        Task3TimerK.theTri = false;
        SimpleTimer.timeCon = true;
        TimeToStopCircleK.checkPos = false;
        TimeToStopTriK.checkPos = false;
        TimeToStopRectK.checkPos = false;
        Application.LoadLevel("Kinect-Task3");
    }

    public void MainMenu()
    {
        Application.LoadLevel("Main Menu");
    }

}
