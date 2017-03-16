using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitychandemo : MonoBehaviour {
    private Animator animator;
    private AnimatorStateInfo animator_state;

    public float mem_rotate;
    private float rotate_speed;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        mem_rotate = 0.0f;
        rotate_speed = 10.0f;
	}
	
	// Update is called once per frame
	void Update () {
        animator_state = animator.GetCurrentAnimatorStateInfo(0);
        if(mem_rotate == 360.0f)
        {
            mem_rotate = 0;
        }
        
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
                        transform.Rotate(0, -(rotate_speed), 0);
                        mem_rotate -= rotate_speed;
                    }
                    else
                    {
                        transform.Rotate(0, rotate_speed, 0);
                        mem_rotate += rotate_speed;
                    }
                }
            }
                    
            if (Input.GetKey("right"))
            {
                if (mem_rotate < 90.0f)
                {
                    transform.Rotate(0, rotate_speed, 0);
                    mem_rotate += rotate_speed;
                }else if(mem_rotate > 90.0f)
                {
                    transform.Rotate(0, -(rotate_speed), 0);
                    mem_rotate -= rotate_speed;
                }
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (mem_rotate > -90.0f)
                {
                    transform.Rotate(0, -(rotate_speed), 0);
                    mem_rotate -= rotate_speed;
                }else if(mem_rotate < -90.0f)
                {
                    transform.Rotate(0, rotate_speed, 0);
                    mem_rotate += rotate_speed;
                }
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                if(Mathf.Abs(mem_rotate) < 180.0f)
                {
                    if(mem_rotate > 0.0f)
                    {
                        transform.Rotate(0, rotate_speed, 0);
                        mem_rotate += rotate_speed;
                    }
                    else
                    {
                        transform.Rotate(0, -(rotate_speed), 0);
                        mem_rotate -= rotate_speed;
                    }
                }
            }
            transform.position += transform.forward * 0.05f;
        }   
    }
}
