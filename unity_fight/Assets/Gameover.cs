using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover : MonoBehaviour {
    private Game_system gamesystem;
    private Animator animator;
    private AnimatorStateInfo animator_state;
    public bool gameover_flag;
	// Use this for initialization
	void Start () {
        gameover_flag = false;
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (gameover_flag)
        {
            animator_state = animator.GetCurrentAnimatorStateInfo(0);
            if(animator_state.fullPathHash == Animator.StringToHash("Base Layer.Gameover"))
            {
                animator.SetBool("is_gameover", false);
            }
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "box_unity")
        {
            gameover_flag = true;
            animator.SetBool("is_gameover", true);
        }
    }
}
