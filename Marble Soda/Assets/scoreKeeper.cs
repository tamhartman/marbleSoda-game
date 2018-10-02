using UnityEngine;
using System.Collections;

public class scoreKeeper : MonoBehaviour
{
    int xPOS;
    int yPOS;
    int gwidth = 200;
    int gheight = 100;
    public int score = 0;
    public GUIStyle GUIFontStyle;
    void OnGUI()
    {
        // Make a label that uses the "box" GUIStyle.
        GUI.Label(new Rect(xPOS + 10, yPOS + 10, gwidth - 20, gheight - 20), score.ToString(), GUIFontStyle);
    }

}
