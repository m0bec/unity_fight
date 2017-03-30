using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_system : MonoBehaviour {
    public enum state_info
    {
        Playing, Pouse, Gameover
    }

    public state_info state;
    public float rank;
    private float rank_time_boundary;
    private float rank_time_count;
    GameObject unitychan;

    float time;
    float gameover_time;
    bool gameover_next_flag;

	// Use this for initialization
	void Start () {
        unitychan = GameObject.Find("unitychan");
        state = state_info.Playing;
        time = 0.0f;
        gameover_time = 1.0f;
        gameover_next_flag = false;

        rank = 0.0f;
        rank_time_boundary = 200.0f;
        rank_time_count = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (unitychan.GetComponent<Gameover>().gameover_flag)
        {
            state = state_info.Gameover;
        }

        if(state == state_info.Gameover)
        {
            time += Time.deltaTime;
            if(time > gameover_time)
            {
                gameover_next_flag = true;
                
            }
            if (gameover_next_flag)
            {
                if(Input.GetKey(KeyCode.Z))
                {
                    SceneManager.LoadScene("start");
                }
            }
        }else if(state == state_info.Playing)
        {
            rank_time_count += Time.deltaTime;
            if(rank_time_count > rank_time_boundary)
            {
                if(rank <= 5.0f)
                {
                    rank += 1.0f;
                    rank_time_count = 0.0f;
                }
            }
        }
	}
}
