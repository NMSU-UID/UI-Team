using UnityEngine;
using System.Collections;

public class TimeToStopTri : MonoBehaviour
{
    GameObject handGes;
    public static bool checkPos = false;

    void Start()
    {
        handGes = GameObject.Find("myTextLeft");
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveTri ta = otherCollider.gameObject.GetComponent<MoveTri>();
        if (ta != null)
        {
            checkPos = true;
        }

    }

    void OnTriggerExit2D(Collider2D otherCollider)
    {
        MoveTri ta = otherCollider.gameObject.GetComponent<MoveTri>();
        if (ta != null)
        {
            checkPos = false;
        }
    }

}