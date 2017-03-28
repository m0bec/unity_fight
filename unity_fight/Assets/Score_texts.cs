using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_texts : MonoBehaviour
{
    public int score;
    private GameObject game_system;
    private Game_system.state_info state_info_; 
    // Use this for initialization
    void Start()
    {
        game_system = GameObject.Find("Gamesystem");
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        state_info_ = game_system.GetComponent<Game_system>().state;
        if (state_info_ == Game_system.state_info.Gameover)
        {
            this.GetComponent<Text>().text = "GAME OVER\n" + "Score " + score.ToString();
        }
        else if (state_info_ == Game_system.state_info.Playing)
        {
            this.GetComponent<Text>().text = "Score " + score.ToString();
        }
        else if (state_info_  == Game_system.state_info.Pouse)
        {

        }
    }
}

