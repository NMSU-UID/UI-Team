using UnityEngine;
using System.Collections;

public class TrackingIndex : MonoBehaviour {

    GameObject indexBone1;
    Vector3 thePos;
    public GUIText theGsture;

    // Update is called once per frame
    void Update()
    {
        indexBone1 = GameObject.FindGameObjectWithTag("indexBone1");
        // Debug.Log(test);
        if (indexBone1 != null)
        {
            Debug.Log(indexBone1);
            thePos = indexBone1.GetComponent<Transform>().position;
            this.gameObject.GetComponent<Transform>().position = new Vector3(thePos.x * 50, thePos.y * 50, -0.5f);
        }

    }

    public void v_sign()
    {
        theGsture.text = "v_sign";
    }

    public void openHand()
    {
        theGsture.text = "open_hand";
    }

    public void thumbUp()
    {
        theGsture.text = "thumb_up";
    }

    public void closeGes()
    {
        theGsture.text = "close";
    }
}
