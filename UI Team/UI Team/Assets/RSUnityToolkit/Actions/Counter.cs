using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour 
{
    public static int theCounter1 = 0;
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveObject ta = otherCollider.gameObject.GetComponent<MoveObject>();
        if (ta != null)
        {
            theCounter1 += 1;
        }
    }

}
