using UnityEngine;
using System.Collections;

public class TimeToStopCircle : MonoBehaviour
{
    public static bool checkPos = false;


    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveCircle ta = otherCollider.gameObject.GetComponent<MoveCircle>();
        if (ta != null)
        {
            checkPos = true;
        }

    }

    void OnTriggerExit2D(Collider2D otherCollider)
    {
        MoveCircle ta = otherCollider.gameObject.GetComponent<MoveCircle>();
        if (ta != null)
        {
            checkPos = false;
        }
    }

}