using UnityEngine;
using System.Collections;

public class SimpleCounterTask3K : MonoBehaviour
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
            theCounter.text = CounterTask3K.theCounter1.ToString();
        }
    }

}
