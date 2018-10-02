using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour {
   public int scoreUp =0;
    int xPOS;
    int yPOS;
    int gwidth = 200;
    int gheight = 100;
    public GUIStyle GUIFontStyle;
    void OnGUI()
    {
        // Make a label that uses the "box" GUIStyle.
        GUI.Label(new Rect(xPOS + 10, yPOS + 10, gwidth - 20, gheight - 20), scoreUp.ToString(), GUIFontStyle);
    }


	
	//Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter (Collider col)
    {

           Debug.Log("collision detected!");
           scoreUp += 1;
           Debug.Log(scoreUp);
    }
}
