using UnityEngine;
using System.Collections;

public class TimeToStop : MonoBehaviour
{
    public static bool checkPos = false;


    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveObject ta = otherCollider.gameObject.GetComponent<MoveObject>();
        if (ta != null)
        {
            checkPos = true;
        }

    }

    void OnTriggerExit2D(Collider2D otherCollider)
    {
        MoveObject ta = otherCollider.gameObject.GetComponent<MoveObject>();
        if (ta != null)
        {
            checkPos = false;
        }
    }

}