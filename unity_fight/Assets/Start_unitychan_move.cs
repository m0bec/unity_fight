using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_unitychan_move : MonoBehaviour {
    private Vector3 unity_vec;
    private Vector3 unity_start_vec;
    private GameObject[] unity_box;
    private Animator animator;

    private bool animate_flag;

    private float move_speed;
    private float escape_time;
    private float measure_time;
    private float move_distance;

    private float idle_poition;
    private float return_distance;
    private bool return_flag;

    private float step;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        unity_start_vec = this.transform.position;
        animate_flag = true;

        escape_time = 1.0f;
        measure_time = 0.0f;
        move_speed = 0.01f;
        move_distance = 0.43f;
        return_flag = false;

        step = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        unity_vec = this.transform.position;
        unity_box = GameObject.FindGameObjectsWithTag("box_unity");

        if (animate_flag)
        {
            if (unity_box.Length == 0)
            {
                if (Mathf.Abs(unity_start_vec.x - unity_vec.x) < move_distance && step == 0.0f)
                {
                    animator.SetBool("Run_flag", true);
                    this.transform.position += new Vector3(move_speed, 0.0f, 0.0f);
                }
                else
                {
                    step = 1.0f;
                    idle_poition = this.transform.position.x;
                    if (Mathf.DeltaAngle(0.0f, transform.eulerAngles.y) > 1.0f)
                    {
                        transform.Rotate(0.0f, -5.0f, 0.0f);
                    }
                    else
                    {
                        animator.SetBool("Run_flag", false);
                    }
                }
            }
            else
            {
                measure_time += Time.deltaTime;

                if (measure_time < escape_time && step == 1.0f)
                {
                    animator.SetBool("Sup_flag", true);
                }
                else
                {
                    animator.SetBool("Sup_flag", false);
                    step = 2.0f;
                }

                if (measure_time > escape_time && step == 2.0f)
                {
                    animator.SetBool("Run_flag", true);
                    animator.SetBool("Esp_flag", true);
                    this.transform.position += new Vector3(-move_speed, 0.0f, 0.0f);
                    if (Mathf.DeltaAngle(270.0f, transform.eulerAngles.y) > 1.0f)
                    {
                        transform.Rotate(0.0f, -5.0f, 0.0f);
                    }
                }

                if(Mathf.Abs(idle_poition - this.transform.position.x) > move_distance && !return_flag && step == 2.0f)
                {
                    this.transform.position = new Vector3(-2.0f, 0.4f, -1.49f);
                    return_flag = true;

                }
            }
        }
        
	}
}
