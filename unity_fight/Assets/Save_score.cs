using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_score : MonoBehaviour {
    bool save_flag;
    int new_score;
    int[] high_score;
    string[] high_score_rank;
    GameObject game_system;
    GameObject scoretext;
    Game_system.state_info state_info_;
    int storage;
    // Use this for initialization
    void Start () {
        game_system = GameObject.Find("Gamesystem");
        scoretext = GameObject.Find("ScoreText");

        save_flag = false;
        high_score = new int[10];
        high_score_rank = new string[10]
        {
            "first",
            "second",
            "third" ,
            "fourth",
            "fifth",
            "sixth",
            "seventh",
            "eighth",
            "ninth",
            "tenth"
        };
	}
	
	// Update is called once per frame
	void Update () {
        state_info_ = game_system.GetComponent<Game_system>().state;
        if (!save_flag && state_info_ == Game_system.state_info.Gameover)
        {
            storage = scoretext.GetComponent<Score_texts>().score;
            for (int i = 0; i < 10; i++)
            {
                high_score[i] = PlayerPrefs.GetInt(high_score_rank[i]);
                if(storage > high_score[i])
                {
                    high_score[i] = storage;
                    storage = high_score[i];
                }
                save_flag = true;
            }
        }
	}
}
