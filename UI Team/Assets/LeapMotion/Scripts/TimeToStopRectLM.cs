using UnityEngine;
using System.Collections;

public class TimeToStopRectLM : MonoBehaviour
{
    public static bool checkPos = false;


    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveRectLM ta = otherCollider.gameObject.GetComponent<MoveRectLM>();
        if (ta != null)
        {
            checkPos = true;
        }

    }

    void OnTriggerExit2D(Collider2D otherCollider)
    {
        MoveRectLM ta = otherCollider.gameObject.GetComponent<MoveRectLM>();
        if (ta != null)
        {
            checkPos = false;
        }
    }

}