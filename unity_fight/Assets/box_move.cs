using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_move : MonoBehaviour {
    public Rigidbody rigidbody;
    public float measure_time;

    private float force;
    private float jump_time;
    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
        force = 5.0f;
        jump_time = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {
        measure_time += Time.deltaTime;

        if(measure_time > jump_time)
        {
            rigidbody.AddForce(0, 0, force, ForceMode.Impulse);
            measure_time = 0.0f;
        }
    }
}
