using UnityEngine;
using System.Collections;

public class CounterLM : MonoBehaviour 
{
    public static int theCounter1 = 0;
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveObjectLM ta = otherCollider.gameObject.GetComponent<MoveObjectLM>();
        if (ta != null)
        {
            theCounter1 += 1;
        }
    }

}
