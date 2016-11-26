using UnityEngine;
using System.Collections;

public class TimeToStopRectK : MonoBehaviour {

    public static bool checkPos = false;


    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveRectK ta = otherCollider.gameObject.GetComponent<MoveRectK>();
        if (ta != null)
        {
            checkPos = true;
        }

    }

    void OnTriggerExit2D(Collider2D otherCollider)
    {
        MoveRectK ta = otherCollider.gameObject.GetComponent<MoveRectK>();
        if (ta != null)
        {
            checkPos = false;
        }
    }
}
