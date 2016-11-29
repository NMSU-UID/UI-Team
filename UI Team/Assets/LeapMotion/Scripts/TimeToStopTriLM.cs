using UnityEngine;
using System.Collections;

public class TimeToStopTriLM : MonoBehaviour
{
    public static bool checkPos = false;

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveTriLM ta = otherCollider.gameObject.GetComponent<MoveTriLM>();
        if (ta != null)
        {
            checkPos = true;
        }

    }

    void OnTriggerExit2D(Collider2D otherCollider)
    {
        MoveTriLM ta = otherCollider.gameObject.GetComponent<MoveTriLM>();
        if (ta != null)
        {
            checkPos = false;
        }
    }

}