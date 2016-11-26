using UnityEngine;
using System.Collections;

public class DetectHandGestureK : MonoBehaviour {
    int handG = 0;
    public GUIText gestureText;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
        handG = DetectJoints.state;
        switch (handG)
            {
                
                case 4:
                gestureText.text= "Lasso";
                    break;
                case 3:
                gestureText.text = "Closed";
                    break;
                case 2:
                gestureText.text = "Open";
                    break;
                case 1:
                gestureText.text = "Not Tracked";
                    break;
                 case 0:
                gestureText.text = "Unknown";
                    break;
                default:
                gestureText.text = "Unknown";
                    break;
            }

        }
}
