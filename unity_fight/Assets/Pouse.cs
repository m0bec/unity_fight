using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pouse : MonoBehaviour {
    private GameObject game_system;
    private Game_system.state_info state_info_;

    public bool pouse_flag;
    bool push_key_flag;
    
	// Use this for initialization
	void Start () {
        game_system = GameObject.Find("Gamesystem");

        pouse_flag = false;
        push_key_flag = false;
	}
	
	// Update is called once per frame
	void Update () {
        state_info_ = game_system.GetComponent<Game_system>().state;

        if (state_info_ == Game_system.state_info.Playing)
        {
            if (Input.GetKey(KeyCode.C))
            {
                if (!push_key_flag)
                {
                    if (!pouse_flag)
                    {
                        Time.timeScale = 0.0f;
                        pouse_flag = true;
                    }
                    else
                    {
                        Time.timeScale = 1.0f;
                        pouse_flag = false;
                    }
                }
                push_key_flag = true;
            }
            else
            {
                push_key_flag = false;
            }
        }
	}
}
