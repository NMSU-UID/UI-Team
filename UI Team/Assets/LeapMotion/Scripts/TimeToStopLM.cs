using UnityEngine;
using System.Collections;

public class TimeToStopLM : MonoBehaviour
{
    public static bool checkPos = false;


    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveObjectLM ta = otherCollider.gameObject.GetComponent<MoveObjectLM>();
        if (ta != null)
        {
            checkPos = true;
        }

    }

    void OnTriggerExit2D(Collider2D otherCollider)
    {
        MoveObjectLM ta = otherCollider.gameObject.GetComponent<MoveObjectLM>();
        if (ta != null)
        {
            checkPos = false;
        }
    }

}