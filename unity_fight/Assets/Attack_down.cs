﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_down : MonoBehaviour {
    private Animator animator;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale > 0)
        {
            if (Input.GetKey("x"))
            {
                animator.SetBool("is_attacking_down", true);
            }
            else
            {
                animator.SetBool("is_attacking_down", false);
            }
        }
    }
}
