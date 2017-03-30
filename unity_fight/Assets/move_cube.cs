using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_cube : MonoBehaviour {
    float time_count;
    Vector3 move;
    Vector3 before_place;
    float field_x;
    float field_z;
	// Use this for initialization
	void Start () {
        time_count = 0.0f;
        move = new Vector3(0.0f, 0.0f, 0.0f);
        field_x = 50.0f;
        field_z = 50.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale > 0)
        {
            time_count += Time.deltaTime;
            if (time_count > 2.0f)
            {
                move = new Vector3(Random.Range(-0.1f, 0.1f) * Time.deltaTime, 0.0f, Random.Range(-0.1f, 0.1f) * Time.deltaTime);
                time_count = 0.0f;
            }

            before_place = this.transform.position;
            this.transform.position += move;
            if (this.transform.position.x > field_x || this.transform.position.x < 0
                || this.transform.position.z > field_z || this.transform.position.z < 0)
            {
                this.transform.position = before_place;
                move.x = -move.x;
                move.z = -move.z;
            }
        }
	}
}
