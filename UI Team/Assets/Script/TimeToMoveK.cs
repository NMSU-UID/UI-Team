﻿using UnityEngine;
using System.Collections;

public class TimeToMoveK : MonoBehaviour {

    public static bool MoveTheObjK = false;

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        DetectJoints ta = otherCollider.gameObject.GetComponent<DetectJoints>();
        if (ta != null && DetectJoints.state == 2)
        {
            MoveTheObjK = true;
        }
    }
}