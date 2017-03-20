using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_unitychan_move : MonoBehaviour {
    private Vector3 unity_vec;
    private GameObject[] unity_box;
    private Animator animator;

    private float escape_time;
    private float measure_time;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();

        escape_time = 1.0f;
        measure_time = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        unity_vec = this.transform.position;
        unity_box = GameObject.FindGameObjectsWithTag("box_unity");
        if (unity_box.Length == 0)
        {
            if (unity_vec.x < -1.0f)
            {
                animator.SetBool("Run_flag", true);
                this.transform.position += new Vector3(0.05f, 0.0f, 0.0f);
            }
            else
            {
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

            if (measure_time < escape_time)
            {
                animator.SetBool("Sup_flag", true);
            }
            else
            {
                animator.SetBool("Sup_flag", false);
            }

            if(measure_time > escape_time)
            {
                animator.SetBool("Run_flag", true);
                this.transform.position += new Vector3(-0.05f, 0.0f, 0.0f);
                if (Mathf.DeltaAngle(270.0f, transform.eulerAngles.y) > 1.0f)
                {
                    transform.Rotate(0.0f, -5.0f, 0.0f);
                }
            }
        }
	}
}
