using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitychandemo : MonoBehaviour {
    private Animator animator;
    private AnimatorStateInfo animator_state;

    private float mem_rotate;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        mem_rotate = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        animator_state = animator.GetCurrentAnimatorStateInfo(0);
        
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow))
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
                if(Mathf.Abs(mem_rotate) > 0.05f)
                {
                    if(mem_rotate > 0.0f)
                    {
                        transform.Rotate(0, -5, 0);
                        mem_rotate -= 5.0f;
                    }
                    else
                    {
                        transform.Rotate(0, 5, 0);
                        mem_rotate += 5.0f;
                    }
                }
            }
                    
            if (Input.GetKey("right"))
            {
                if (mem_rotate < 90.0f)
                {
                    transform.Rotate(0, 5, 0);
                    mem_rotate += 5.0f;
                }else if(mem_rotate > 90.0f)
                {
                    transform.Rotate(0, -5, 0);
                    mem_rotate -= 5.0f;
                }
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (mem_rotate > -90.0f)
                {
                    transform.Rotate(0, -5, 0);
                    mem_rotate -= 5.0f;
                }else if(mem_rotate < -90.0f)
                {
                    transform.Rotate(0, 5, 0);
                    mem_rotate += 5.0f;
                }
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                if(Mathf.Abs(mem_rotate) < 180.0f)
                {
                    if(mem_rotate > 0.0f)
                    {
                        transform.Rotate(0, 5, 0);
                        mem_rotate += 5.0f;
                    }
                    else
                    {
                        transform.Rotate(0, -5, 0);
                        mem_rotate -= 5.0f;
                    }
                }
            }
            transform.position += transform.forward * 0.05f;
        }   
    }
}
