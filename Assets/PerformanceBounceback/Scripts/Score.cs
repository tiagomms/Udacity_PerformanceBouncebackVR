﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameManager gameManager;
    private Text text;

	// Use this for initialization
	void Start () {
		text = GetComponentInChildren<Text>();
		ScoreUIChange();
	}

	// Update is called once per frame
	public void ScoreUIChange () {
		//TODO: change when is necessary
		text.text = "Score: " + gameManager.score.ToString();
	}
}
