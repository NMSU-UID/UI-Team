using UnityEngine;
using System.Collections;

public class TimeToStopK : MonoBehaviour
{
    public static bool checkPos = false;

    
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveObjectK ta = otherCollider.gameObject.GetComponent<MoveObjectK>();
        if (ta != null)
        {
            checkPos = true;
        }

    }

    void OnTriggerExit2D(Collider2D otherCollider)
    {
        MoveObjectK ta = otherCollider.gameObject.GetComponent<MoveObjectK>();
        if (ta != null)
        {
            checkPos = false;
        }
    }
}