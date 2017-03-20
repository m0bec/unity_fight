using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_unitychan_move : MonoBehaviour {
    private Vector3 unity_vec;
    private GameObject[] unity_box;
    private Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
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
	}
}
