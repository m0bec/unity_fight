using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIt_attack : MonoBehaviour {
    new public Rigidbody rigidbody;

    private box_move Box_move;
    private float impulse;

    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
        impulse = 1000.0f;
	}
	
	// Update is called once per frame
	void Update () {
   
    }

    void OnCollisionEnter(Collision collision)
    {
        Box_move = GetComponent<box_move>();
        if (collision.gameObject.tag == "weapon")
        {
            rigidbody.AddForce(-Box_move.vec_x * impulse, 0, -Box_move.vec_z * impulse, ForceMode.Impulse);
        }
    }
}
