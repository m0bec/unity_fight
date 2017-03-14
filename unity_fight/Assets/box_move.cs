using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_move : MonoBehaviour {
    new public Rigidbody rigidbody;
    public float measure_time;

    private float force;
    private float jump_time;
    private Vector3 vector;
    private float vec_x;
    private float vec_z;
    private float vec_direct;
    private float vec_scale;
    private float rotation;
    private float rotation_speed;
    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
        force = 5.0f;
        jump_time = 1.85f;
        vec_scale = 0.01f;
        rotation_speed = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
        measure_time += Time.deltaTime;
        vector = GameObject.Find("unitychan").transform.position;

        vec_x = vector.x - this.transform.position.x;
        vec_z = vector.z - this.transform.position.z;
        //回転
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(new Vector3(vector.x, 0, vector.z)), rotation_speed);
        vec_direct = Mathf.Sqrt(Mathf.Pow(vec_x, 2.0f) + Mathf.Pow(vec_z, 2.0f));
        vec_x = (vec_x / vec_direct) * vec_scale;
        vec_z = (vec_z / vec_direct) * vec_scale;
        this.transform.position += new Vector3(vec_x, 0, vec_z);
        this.transform.Rotate(0, rotation, 0);

        if (measure_time > jump_time)
        {
            rigidbody.AddForce(0, force, 0, ForceMode.Impulse);
            measure_time = 0.0f;
        }
    }
}
