using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBoxUnity : MonoBehaviour {
    public Score_texts score_text;
    GameObject score_text_obj;
	// Use this for initialization
	void Start () {
        score_text_obj = GameObject.Find("ScoreText");

    }
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.y < -5.0f)
        {
            score_text = score_text_obj.GetComponent<Score_texts>();
            score_text.score += 10;
            Destroy(gameObject);
        }
	}
}
