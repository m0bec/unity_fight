using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_texts : MonoBehaviour
{
    public int score;
    private GameObject game_system;
    private Game_system.state_info state_info_;

    private GameObject gameover1;
    private GameObject gameover2;
    private GameObject gameover3;
    // Use this for initialization
    void Start()
    {
        game_system = GameObject.Find("Gamesystem");

        score = 0;
        gameover1 = GameObject.Find("Gameover1");
        gameover2 = GameObject.Find("Gameover2");
        gameover3 = GameObject.Find("Gameover3");
    }

    // Update is called once per frame
    void Update()
    {
        state_info_ = game_system.GetComponent<Game_system>().state;
        if (state_info_ == Game_system.state_info.Gameover)
        {
            this.GetComponent<Text>().text = "";
            gameover1.GetComponent<Text>().text = "GAME OVER";
            gameover2.GetComponent<Text>().text = "Score " + score.ToString();
            gameover3.GetComponent<Text>().text = "Please push Z key";
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

