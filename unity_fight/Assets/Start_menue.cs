using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start_menue : MonoBehaviour {
    enum state_info
    {
        Lower_limit, Start, Information, Score, Exit, Upper_limit
    }

    private GameObject start;
    private GameObject information;
    private GameObject score;
    private GameObject escape;
    private state_info state;
    private bool key_push_flag;
    private float key_time;
    private float wait_time;

    void Select_menue()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            if(state == state_info.Start)
            {
                SceneManager.LoadScene("unitychan_make");
            }
        }
    }

    // Use this for initialization
    void Start () {
        state = state_info.Start;
        start = GameObject.Find("Start");
        information = GameObject.Find("Information");
        score = GameObject.Find("Score");
        escape = GameObject.Find("Exit");

        wait_time = 0.3f;
        key_time = 0.0f;
        key_push_flag = false;
    }
    // Update is called once per frame
    void Update () {
        key_time += Time.deltaTime;

        Select_menue();
        if (Input.GetKey(KeyCode.UpArrow) && !key_push_flag)
        {
            state -= 1;
            if(state == state_info.Lower_limit)
            {
                state = state_info.Exit;
            }
            key_push_flag = true;
            key_time = 0.0f;
        }else if (Input.GetKey(KeyCode.DownArrow) && !key_push_flag)
        {
            state += 1;
            if(state == state_info.Upper_limit)
            {
                state = state_info.Start;
            }
            key_push_flag = true;
            key_time = 0.0f;
        }

        if(key_push_flag && key_time > wait_time)
        {
            key_push_flag = false;
        }

        switch (state)
        {
            case state_info.Start:
                start.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                information.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
                score.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
                escape.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
                break;

            case state_info.Information:
                start.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
                information.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                score.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
                escape.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
                break;

            case state_info.Score:
                start.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
                information.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
                score.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                escape.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
                break;

            case state_info.Exit:
                start.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
                information.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
                score.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
                escape.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                break;
        }
	}
}
