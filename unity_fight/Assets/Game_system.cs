using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_system : MonoBehaviour {
    public enum state_info
    {
        Playing, Pouse, Gameover
    }

    public state_info state;
    GameObject unitychan;
	// Use this for initialization
	void Start () {
        unitychan = GameObject.Find("unitychan");
        state = state_info.Playing;
	}
	
	// Update is called once per frame
	void Update () {
        if (unitychan.GetComponent<Gameover>().gameover_flag)
        {
            state = state_info.Gameover;
        }
	}
}
