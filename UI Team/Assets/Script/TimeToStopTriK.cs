using UnityEngine;
using System.Collections;

public class TimeToStopTriK : MonoBehaviour {

    public static bool checkPos = false;


    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveTriK ta = otherCollider.gameObject.GetComponent<MoveTriK>();
        if (ta != null)
        {
            checkPos = true;
        }

    }

    void OnTriggerExit2D(Collider2D otherCollider)
    {
        MoveTriK ta = otherCollider.gameObject.GetComponent<MoveTriK>();
        if (ta != null)
        {
            checkPos = false;
        }
    }
}
