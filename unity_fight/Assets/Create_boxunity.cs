using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_boxunity : MonoBehaviour {
    public float create_time;
    private float measure_time;
    public GameObject boxunity;
	// Use this for initialization
	void Start () {
        create_time = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
        measure_time += Time.deltaTime;

        if(measure_time > create_time)
        {
            Instantiate(boxunity);
            measure_time = 0.0f;
        }
	}
}
