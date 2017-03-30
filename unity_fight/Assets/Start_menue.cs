using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start_menue : MonoBehaviour {
    public enum state_info
    {
        Lower_limit, Start, Information, Score, Exit, Upper_limit, Information_text, High_score
    }

    private GameObject start;
    private GameObject information;
    private GameObject score;
    private GameObject escape;
    private GameObject information_text;
    private GameObject high_score;

    public state_info state;
    private bool key_push_flag;
    private float key_time;
    private float wait_time;
    private float decision_time;
    private bool decision_flag;

    void Select_menue()
    {
        if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.Space))
        {
            decision_flag = true;
            decision_time = 0.0f;

            if(state == state_info.Start)
            {
                SceneManager.LoadScene("unitychan_make");
            }else if(state == state_info.Information)
            {
                start.GetComponent<Text>().enabled = false;
                information.GetComponent<Text>().enabled = false;
                score.GetComponent<Text>().enabled = false;
                escape.GetComponent<Text>().enabled = false;
                information_text.GetComponent<Text>().enabled = true;
                high_score.GetComponent<Text>().enabled = false;
                state = state_info.Information_text;
            }else if(state == state_info.Information_text)
            {
                start.GetComponent<Text>().enabled = true;
                information.GetComponent<Text>().enabled = true;
                score.GetComponent<Text>().enabled = true;
                escape.GetComponent<Text>().enabled = true;
                information_text.GetComponent<Text>().enabled = false;
                high_score.GetComponent<Text>().enabled = false;
                state = state_info.Information;
            }else if(state == state_info.Exit)
            {
                Application.Quit();
            }else if(state == state_info.Score)
            {
                start.GetComponent<Text>().enabled = false;
                information.GetComponent<Text>().enabled = false;
                score.GetComponent<Text>().enabled = false;
                escape.GetComponent<Text>().enabled = false;
                information_text.GetComponent<Text>().enabled = false;
                high_score.GetComponent<Text>().enabled = true;
                state = state_info.High_score;

                high_score.GetComponent<Text>().text =
                "1st : " + PlayerPrefs.GetInt("first") + "\n" +
                "2nd : " + PlayerPrefs.GetInt("second") + "\n" +
                "3rd : " + PlayerPrefs.GetInt("third") + "\n" +
                "4th : " + PlayerPrefs.GetInt("fourth") + "\n" +
                "5th : " + PlayerPrefs.GetInt("fifth") + "\n" +
                "6th : " + PlayerPrefs.GetInt("sixth") + "\n" +
                "7th : " + PlayerPrefs.GetInt("seventh") + "\n" +
                "8th : " + PlayerPrefs.GetInt("eighth") + "\n" +
                "9th : " + PlayerPrefs.GetInt("ninth") + "\n" +
                "10th: " + PlayerPrefs.GetInt("tenth") + "\n";
            }else if(state == state_info.High_score)
            {
                start.GetComponent<Text>().enabled = true;
                information.GetComponent<Text>().enabled = true;
                score.GetComponent<Text>().enabled = true;
                escape.GetComponent<Text>().enabled = true;
                information_text.GetComponent<Text>().enabled = false;
                high_score.GetComponent<Text>().enabled = false;
                state = state_info.Score;
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
        information_text = GameObject.Find("Information_text");
        high_score = GameObject.Find("High_score");

        information_text.GetComponent<Text>().enabled = false;

        wait_time = 0.3f;
        key_time = 0.0f;
        decision_time = 0.0f;
        key_push_flag = false;
        decision_flag = false;
    }
    // Update is called once per frame
    void Update () {
        key_time += Time.deltaTime;
        decision_time += Time.deltaTime;

        if (!decision_flag)
        {
            Select_menue();
        }
        if(decision_time > wait_time)
        {
            decision_flag = false;
        }

        if (state == state_info.Start || state == state_info.Information || state == state_info.Score || state == state_info.Exit)
        {
            if (Input.GetKey(KeyCode.UpArrow) && !key_push_flag)
            {
                state -= 1;
                if (state <= state_info.Lower_limit)
                {
                    state = state_info.Exit;
                }
                key_push_flag = true;
                key_time = 0.0f;
            }
            else if (Input.GetKey(KeyCode.DownArrow) && !key_push_flag)
            {
                state += 1;
                if (state >= state_info.Upper_limit)
                {
                    state = state_info.Start;
                }
                key_push_flag = true;
                key_time = 0.0f;
            }

            if (key_push_flag && key_time > wait_time)
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
}
