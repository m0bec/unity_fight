using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBoxUnity : MonoBehaviour {
    public Score_texts score_text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.y < -5.0f)
        {
            score_text = GameObject.Find("ScoreText").GetComponent<Score_texts>();
            score_text.score += 10;
            Destroy(gameObject);
        }
	}
}
