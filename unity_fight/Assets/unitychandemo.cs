using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitychandemo : MonoBehaviour {
    private Animator animator;
    private AnimatorStateInfo animator_state;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        animator_state = animator.GetCurrentAnimatorStateInfo(0);
        
        if (Input.GetKey("up") || Input.GetKey("right") || Input.GetKey("left"))
        {
            animator.SetBool("is_running", true);
        }
        else
        {
            animator.SetBool("is_running", false);
        }

        if (animator_state.fullPathHash == Animator.StringToHash("Base Layer.Running"))
        {
            if (Input.GetKey("up"))
            {
                transform.position += transform.forward * 0.01f;
            }
                    
            if (Input.GetKey("right"))
            {
                transform.Rotate(0, 10, 0);
            }
            if (Input.GetKey("left"))
            {
                transform.Rotate(0, -10, 0);
            }
        }   
    }
}
