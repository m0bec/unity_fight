using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {
    private box_move Box_move;
    private Active_weapons active_weapons;
    private GameObject unity_chan;
    private AudioClip audio;

    private float impulse;
    // Use this for initialization
    void Start () {
        impulse = 1000.0f;
        unity_chan = GameObject.Find("unitychan");
        audio = GetComponent<AudioSource>().clip;
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnTriggerEnter(Collider collider)
    {
        Box_move = collider.gameObject.GetComponent<box_move>();
        active_weapons = unity_chan.GetComponent<Active_weapons>();
        if (active_weapons.attack_flag)
        {
            
            collider.gameObject.GetComponent<Rigidbody>().AddForce(-Box_move.vec_x * impulse, 1.0f, -Box_move.vec_z * impulse, ForceMode.Impulse);
            GetComponent<AudioSource>().PlayOneShot(audio);

        }
        
    }
}
