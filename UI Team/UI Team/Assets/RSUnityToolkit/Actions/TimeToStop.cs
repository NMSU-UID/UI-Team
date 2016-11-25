using UnityEngine;
using System.Collections;

public class TimeToStop : MonoBehaviour
{
    GameObject handGes;
    public static bool checkPos = false;

    void Start()
    {
        handGes = GameObject.Find("myTextLeft");
    }

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