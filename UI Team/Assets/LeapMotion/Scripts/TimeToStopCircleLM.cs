using UnityEngine;
using System.Collections;

public class TimeToStopCircleLM : MonoBehaviour
{
    public static bool checkPos = false;


    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveCircleLM ta = otherCollider.gameObject.GetComponent<MoveCircleLM>();
        if (ta != null)
        {
            checkPos = true;
        }

    }

    void OnTriggerExit2D(Collider2D otherCollider)
    {
        MoveCircleLM ta = otherCollider.gameObject.GetComponent<MoveCircleLM>();
        if (ta != null)
        {
            checkPos = false;
        }
    }

}