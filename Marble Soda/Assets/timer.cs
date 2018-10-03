using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour {

    public GameObject ball;
    private int numBalls = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Space)){
            Instantiate(ball);
            numBalls = 1;
        }
       // if (numBalls > 0)
	}
}
