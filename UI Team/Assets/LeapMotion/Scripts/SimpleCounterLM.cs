using UnityEngine;
using System.Collections;

public class SimpleCounterLM : MonoBehaviour

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
            theCounter.text = CounterLM.theCounter1.ToString();
        }
    }

}
