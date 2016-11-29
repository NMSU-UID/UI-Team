using UnityEngine;
using System.Collections;

public class TimeToMoveCircleLM : MonoBehaviour
{
    GameObject handGes;
    public static bool MoveTheObj = false;

    void Start()
    {
        handGes = GameObject.Find("myTextLeft");
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        TrackingIndex ta = otherCollider.gameObject.GetComponent<TrackingIndex>();
        if (ta != null && handGes.GetComponent<GUIText>().text == "open_hand")
        {
            if (MoveCircleLM.movingFlag)
            {
                MoveTheObj = true;
            }
        }
    }

}