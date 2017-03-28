using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIt_attack : MonoBehaviour {
    new public Rigidbody rigidbody;
    private box_move Box_move;
    private Active_weapons active_weapons;

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
        if (collision.gameObject.tag == "weapon")
        {
            Box_move = GetComponent<box_move>();
            active_weapons = GameObject.Find("unitychan").GetComponent<Active_weapons>();
            if (active_weapons.attack_flag)
            {
                rigidbody.AddForce(-Box_move.vec_x * impulse, 0, -Box_move.vec_z * impulse, ForceMode.Impulse);
            }
        }
    }
}
