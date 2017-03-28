using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover : MonoBehaviour {
    Game_system gamesystem;
    public bool gameover_flag;
	// Use this for initialization
	void Start () {
        gameover_flag = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "box_unity")
        {
            gameover_flag = true;
        }
    }
}
