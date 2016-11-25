using UnityEngine;
using System.Collections;

public class TimeToStopCircle : MonoBehaviour
{
    GameObject handGes;
    public static bool checkPos = false;

    void Start()
    {
        handGes = GameObject.Find("myTextLeft");
    }

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