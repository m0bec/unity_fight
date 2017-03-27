using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start_text : MonoBehaviour {
    enum state
    {
        Start, Tutorial, Score, Exit
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Text>().text = "Score point\n";
    }
}
