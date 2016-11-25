using UnityEngine;
using System.Collections;

public class SimpleCounter : MonoBehaviour

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
            theCounter.text = Counter.theCounter1.ToString();
        }
    }

}
