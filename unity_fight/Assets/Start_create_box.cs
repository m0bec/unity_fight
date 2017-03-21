using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_create_box : MonoBehaviour {
    private Vector3 vec;
    public float create_time;
    private float measure_time;

    public bool create_flag;
    public GameObject boxunity;
	// Use this for initialization
	void Start () {
        create_flag = true;
        vec = this.transform.position;
        create_time = 5.0f;
        measure_time = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (create_flag)
        {
            measure_time += Time.deltaTime;

            if (measure_time > create_time)
            {
                Instantiate(boxunity, vec, Quaternion.Euler(0, -90, 0));
                create_flag = false;
            }
        }
	}
}
