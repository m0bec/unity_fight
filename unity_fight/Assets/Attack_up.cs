using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_up : MonoBehaviour {
    private Animator animator;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale > 0)
        {
            if (Input.GetKey("z"))
            {
                animator.SetBool("is_attacking_up", true);
            }
            else
            {
                animator.SetBool("is_attacking_up", false);
            }
        }
    }
}
