using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour {
    private GameObject gameobject;
    private Vector3 before_position;
    private float rotate_speed;
    // Use this for initialization
    void Start () {
        rotate_speed = 50.0f;

        gameobject = GameObject.Find("unitychan");
        before_position = gameobject.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += gameobject.transform.position - before_position;
        before_position = gameobject.transform.position;
        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(gameobject.transform.position, Vector3.up, rotate_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.RotateAround(gameobject.transform.position, Vector3.up, -rotate_speed * Time.deltaTime);
        }
        

    }
}
