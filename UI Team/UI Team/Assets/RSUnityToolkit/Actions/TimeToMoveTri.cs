﻿using UnityEngine;
using System.Collections;

public class TimeToMoveTri : MonoBehaviour
{

    GameObject handGes;
    public static bool MoveTheObj = false;

    void Start()
    {
        handGes = GameObject.Find("myTextLeft");
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        TrackingAction ta = otherCollider.gameObject.GetComponent<TrackingAction>();
        if (ta != null && handGes.GetComponent<GUIText>().text == "spreadfingers")
        {
            MoveTheObj = true;
        }
    }

}