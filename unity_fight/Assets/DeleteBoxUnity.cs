using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBoxUnity : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
	}
}
