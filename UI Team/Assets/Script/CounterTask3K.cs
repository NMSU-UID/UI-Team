using UnityEngine;
using System.Collections;

public class CounterTask3K : MonoBehaviour {

    public static int theCounter1 = 0;
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveRectK ta = otherCollider.gameObject.GetComponent<MoveRectK>();
        MoveTriK ta1 = otherCollider.gameObject.GetComponent<MoveTriK>();
        MoveCircleK ta2 = otherCollider.gameObject.GetComponent<MoveCircleK>();
        if (ta != null || ta1 != null || ta2 != null)
        {
            theCounter1 += 1;
        }
    }
}
