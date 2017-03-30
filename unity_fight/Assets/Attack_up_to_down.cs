using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_up_to_down : MonoBehaviour {
    private Animator animator;
    private AnimatorStateInfo animator_state;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale > 0)
        {
            animator_state = animator.GetCurrentAnimatorStateInfo(0);

            if (animator_state.fullPathHash == Animator.StringToHash("Base Layer.Attack_up"))
            {
                if (Input.GetKey("x"))
                {
                    animator.SetBool("is_attacking_up_to_down", true);
                }
            }
            else if (animator_state.fullPathHash == Animator.StringToHash("Base Layer.Attack_up_to_down"))
            {
                animator.SetBool("is_attacking_up_to_down", false);
            }
        }
    }
}
