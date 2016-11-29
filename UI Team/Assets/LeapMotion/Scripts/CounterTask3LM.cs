using UnityEngine;
using System.Collections;

public class CounterTask3LM : MonoBehaviour
{
    public static int theCounter1 = 0;
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveRectLM ta = otherCollider.gameObject.GetComponent<MoveRectLM>();
        MoveTriLM ta1 = otherCollider.gameObject.GetComponent<MoveTriLM>();
        MoveCircleLM ta2 = otherCollider.gameObject.GetComponent<MoveCircleLM>();
        if (ta != null || ta1 != null || ta2 != null)
        {
            theCounter1 += 1;
        }
    }

}
