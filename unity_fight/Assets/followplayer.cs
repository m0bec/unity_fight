﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour {
    private GameObject game_system;
    private Game_system.state_info state_info_;

    private GameObject gameobject;
    private Vector3 before_position;
    private float rotate_speed;
    private Vector3 rotate_target;
    private bool push_d_flag;
    // Use this for initialization
    void Start () {
        game_system = GameObject.Find("Gamesystem");

        rotate_speed = 100.0f;

        gameobject = GameObject.Find("unitychan");
        before_position = gameobject.transform.position;

        push_d_flag = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale > 0)
        {
            state_info_ = game_system.GetComponent<Game_system>().state;

            if (state_info_ == Game_system.state_info.Playing)
            {
                transform.position += gameobject.transform.position - before_position;
                before_position = gameobject.transform.position;
                if (Input.GetKey(KeyCode.S))
                {
                    transform.RotateAround(gameobject.transform.position, Vector3.up, rotate_speed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.A))
                {
                    transform.RotateAround(gameobject.transform.position, Vector3.up, -rotate_speed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.D))
                {
                    if (!push_d_flag)
                    {
                        rotate_target = gameobject.transform.localEulerAngles - transform.localEulerAngles;
                        transform.RotateAround(gameobject.transform.position, Vector3.up, rotate_target.y);
                        push_d_flag = true;
                    }
                }
                else
                {
                    push_d_flag = false;
                }
            }
            else if (state_info_ == Game_system.state_info.Gameover)
            {
                transform.position = gameobject.transform.position;
                transform.position += new Vector3(0.0f, 4.0f, 0.0f);
                transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
            }
        }

    }
}
