using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitychandemo : MonoBehaviour {
    private Animator animator;
    private AnimatorStateInfo animator_state;
    private Transform transform;
    private GameObject camera;

    private float margine;
    private float rotate_speed;
    private Vector3 memory_place;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        camera = GameObject.Find("Main Camera");
        rotate_speed = 30.0f;
        margine = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {
        animator_state = animator.GetCurrentAnimatorStateInfo(0);
        transform = GetComponent<Transform>();
        
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
            if (Input.GetKey(KeyCode.UpArrow))
            {
                if(Mathf.DeltaAngle(camera.transform.eulerAngles.y, transform.eulerAngles.y) < -(rotate_speed))
                {
                    transform.Rotate(0, rotate_speed, 0);
                }else if(Mathf.DeltaAngle(camera.transform.eulerAngles.y, transform.eulerAngles.y) > rotate_speed)
                {
                    transform.Rotate(0, -(rotate_speed), 0);
                }
                else
                {
                    transform.rotation = Quaternion.Euler(0.0f, camera.transform.eulerAngles.y, 0.0f);
                }
            }
                    
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (Mathf.DeltaAngle(camera.transform.eulerAngles.y + 90.0f, transform.eulerAngles.y) < -(rotate_speed))
                {
                    transform.Rotate(0, rotate_speed, 0);
                }else if(Mathf.DeltaAngle(camera.transform.eulerAngles.y + 90.0f, transform.eulerAngles.y) > rotate_speed)
                {
                    transform.Rotate(0, -(rotate_speed), 0);
                }
                else
                {
                    transform.rotation = Quaternion.Euler(0.0f, camera.transform.eulerAngles.y + 90.0f, 0.0f);
                }
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (Mathf.DeltaAngle(camera.transform.eulerAngles.y + 270.0f, transform.eulerAngles.y) < -(rotate_speed))
                {
                    transform.Rotate(0, rotate_speed, 0);
                }else if(Mathf.DeltaAngle(camera.transform.eulerAngles.y + 270.0f, transform.eulerAngles.y) > rotate_speed)
                {
                    transform.Rotate(0, -(rotate_speed), 0);
                }
                else
                {
                    transform.rotation = Quaternion.Euler(0.0f, camera.transform.eulerAngles.y + 270.0f, 0.0f);
                }
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                if (Mathf.DeltaAngle(camera.transform.eulerAngles.y + 180.0f, transform.eulerAngles.y) < -(rotate_speed))
                {
                    transform.Rotate(0, rotate_speed, 0);
                }
                else if (Mathf.DeltaAngle(camera.transform.eulerAngles.y + 180.0f, transform.eulerAngles.y) > rotate_speed)
                {
                    transform.Rotate(0, -(rotate_speed), 0);
                }
                else
                {
                    transform.rotation = Quaternion.Euler(0.0f, camera.transform.eulerAngles.y + 180.0f, 0.0f);
                }
            }

            memory_place = transform.position;
            transform.position += transform.forward * 0.05f;
            if(transform.position.x > 100 || transform.position.x < 0 
                || transform.position.z > 100 || transform.position.z < 0)
            {
                transform.position = memory_place;
            }
        }   
    }
}
