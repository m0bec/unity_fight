using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_box_move : MonoBehaviour {
    private float measure_move;
    private Vector3 start_position;
    private Rigidbody rigidbody;
    private float upper_move_distance;

    private float move_speed;
    private float measure_time;
    private float jump_time;
    private float force;
	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        start_position = this.transform.position;
        move_speed = 0.01f;
        measure_time = 0.0f;
        jump_time = 1.85f;
        force = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
        measure_time += Time.deltaTime;
        measure_move = Mathf.Abs(this.transform.position.x - start_position.x);
        if(measure_move < upper_move_distance)
        {
            this.transform.position += new Vector3(-move_speed, 0, 0);
        }

        if(measure_time > jump_time)
        {
            rigidbody.AddForce(0.0f, force, 0.0f, ForceMode.Impulse);
            measure_time = 0.0f;
        }
	}
}
