using UnityEngine;
using System.Collections;

public class TimeToStopRect : MonoBehaviour
{
    GameObject handGes;
    public static bool checkPos = false;

    void Start()
    {
        handGes = GameObject.Find("myTextLeft");
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveRect ta = otherCollider.gameObject.GetComponent<MoveRect>();
        if (ta != null)
        {
            checkPos = true;
        }

    }

    void OnTriggerExit2D(Collider2D otherCollider)
    {
        MoveRect ta = otherCollider.gameObject.GetComponent<MoveRect>();
        if (ta != null)
        {
            checkPos = false;
        }
    }

}