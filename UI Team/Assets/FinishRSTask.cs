using UnityEngine;
using System.Collections;

public class FinishRSTask : MonoBehaviour {

    private GUIStyle guiStyle = new GUIStyle();

   
    void OnGUI()
    {
        const int buttonWidth = 120;
        const int buttonHeight = 60;
        guiStyle.fontSize = 30;
        guiStyle.normal.textColor = Color.white;
        GUI.Label(new Rect((Screen.width / 2) - 80, (Screen.height / 3) + 120, 100, 20), "Good Job!", guiStyle);

        if (
            GUI.Button(
                new Rect(
                    Screen.width / 2 - (buttonWidth / 2),
                    (1 * Screen.height / 3) - (buttonHeight / 2),
                    buttonWidth,
                    buttonHeight
                ),
                "RealSense Menu"
            ))
        {
            Application.LoadLevel("RealSense Menu");
        }
        if (
            GUI.Button(
                new Rect(
                    Screen.width / 2 - (buttonWidth / 2),
                    (2 * Screen.height / 3) - (buttonHeight / 2),
                    buttonWidth,
                    buttonHeight
                ),
                "Main Menu"
            ))
        {
            Application.LoadLevel("Main Menu");
        }

    }
}
