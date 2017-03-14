using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_down_to_up : MonoBehaviour {
    private Animator animator;
    private AnimatorStateInfo animator_state;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        animator_state = animator.GetCurrentAnimatorStateInfo(0);

        if (animator_state.fullPathHash == Animator.StringToHash("Base Layer.Attack_down"))
        {
            if (Input.GetKey("z"))
            {
                animator.SetBool("is_attacking_down_to_up", true);
            }
        }
        else if (animator_state.fullPathHash == Animator.StringToHash("Base Layer.Attack_down_to_up"))
        {
            animator.SetBool("is_attacking_down_to_up", false);
        }
    }
}
