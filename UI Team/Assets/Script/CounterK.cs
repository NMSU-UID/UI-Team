using UnityEngine;
using System.Collections;

public class CounterK : MonoBehaviour
{
    public static int theCounter1 = 0;
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveObjectK ta = otherCollider.gameObject.GetComponent<MoveObjectK>();
        if (ta != null)
        {
            theCounter1 += 1;
        }
    }

}