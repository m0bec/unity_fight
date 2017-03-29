using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_boxunity : MonoBehaviour {
    private GameObject game_system;
    private Game_system.state_info state_info_;

    public float create_time;
    private float measure_time;
    public GameObject boxunity;
    private Vector3 vec;
    private float rank;
    // Use this for initialization
    void Start () {
        game_system = GameObject.Find("Gamesystem");

        create_time = 10.0f;
        vec = this.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        
        state_info_ = game_system.GetComponent<Game_system>().state;
        rank = game_system.GetComponent<Game_system>().rank;
        if (state_info_ == Game_system.state_info.Playing)
        {
            measure_time += Time.deltaTime;

            if (measure_time > create_time - rank)
            {
                vec = this.transform.position;
                Instantiate(boxunity, vec, Quaternion.Euler(0, 0, 0));
                measure_time = 0.0f;
            }
        }
 	}
}
