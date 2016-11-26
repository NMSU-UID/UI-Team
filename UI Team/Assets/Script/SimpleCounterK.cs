using UnityEngine;
using System.Collections;

public class SimpleCounterK : MonoBehaviour

{
    public GUIText theCounter;
    public GUIText theCount;

    void Start()
    {
        theCount.text = "Counter: ";
    }

    void Update()
    {
        if (SimpleTimer.timeCon)
        {
            theCounter.text = CounterK.theCounter1.ToString();
        }
    }

}
