using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBGM : MonoBehaviour {
    private GameObject game_system;
    private Game_system.state_info state_info_;
    private AudioSource audio;
    // Use this for initialization
    void Start () {
        game_system = GameObject.Find("Gamesystem");
        audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        state_info_ = game_system.GetComponent<Game_system>().state;

        if(state_info_ != Game_system.state_info.Playing)
        {
            audio.Stop();
        }
    }
}
