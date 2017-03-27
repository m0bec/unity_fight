using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    private bool key_flag;

    // Use this for initialization
    void Start () {
        state = state_info.Start;
        start = GameObject.Find("Start");
        information = GameObject.Find("Information");
        score = GameObject.Find("Score");
        escape = GameObject.Find("Exit");
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            state -= 1;
            if(state == state_info.Lower_limit)
            {
                state = state_info.Exit;
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            state += 1;
            if(state == state_info.Upper_limit)
            {
                state = state_info.Start;
            }
        }

        switch (state)
        {
            case state_info.Start:
                start.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
                information.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                score.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                escape.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                break;

            case state_info.Information:
                start.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                information.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
                score.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                escape.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                break;

            case state_info.Score:
                start.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                information.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                score.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
                escape.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                break;

            case state_info.Exit:
                start.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                information.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                score.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
                escape.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
                break;
        }
	}
}
