using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pouse : MonoBehaviour {
    bool pouse_flag;
    bool push_key_flag;
	// Use this for initialization
	void Start () {
        pouse_flag = false;
        push_key_flag = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.C))
        {
            if (!push_key_flag)
            {
                if (pouse_flag)
                {
                    Time.timeScale = 0.0f;
                }
                else
                {
                    Time.timeScale = 1.0f;
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
