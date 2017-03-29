using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {
    private box_move Box_move;
    private Active_weapons active_weapons;

    private float impulse;
    // Use this for initialization
    void Start () {
        impulse = 1000.0f;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collider)
    {
        Box_move = collider.gameObject.GetComponent<box_move>();
        active_weapons = GameObject.Find("unitychan").GetComponent<Active_weapons>();
        if (active_weapons.attack_flag)
        {
            collider.gameObject.GetComponent<Rigidbody>().AddForce(-Box_move.vec_x * impulse, 1.0f, -Box_move.vec_z * impulse, ForceMode.Impulse);
        }
        
    }
}
