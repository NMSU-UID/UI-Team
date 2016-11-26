using UnityEngine;
using System.Collections;

public class TimeToStopCircleK : MonoBehaviour {

    public static bool checkPos = false;


    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveCircleK ta = otherCollider.gameObject.GetComponent<MoveCircleK>();
        if (ta != null)
        {
            checkPos = true;
        }

    }

    void OnTriggerExit2D(Collider2D otherCollider)
    {
        MoveCircleK ta = otherCollider.gameObject.GetComponent<MoveCircleK>();
        if (ta != null)
        {
            checkPos = false;
        }
    }
}
