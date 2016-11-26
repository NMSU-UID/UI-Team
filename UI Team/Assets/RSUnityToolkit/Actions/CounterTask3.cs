using UnityEngine;
using System.Collections;

public class CounterTask3 : MonoBehaviour
{
    public static int theCounter1 = 0;
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveRect ta = otherCollider.gameObject.GetComponent<MoveRect>();
        MoveTri ta1 = otherCollider.gameObject.GetComponent<MoveTri>();
        MoveCircle ta2 = otherCollider.gameObject.GetComponent<MoveCircle>();
        if (ta != null || ta1 != null || ta2 != null)
        {
            theCounter1 += 1;
        }
    }

}
