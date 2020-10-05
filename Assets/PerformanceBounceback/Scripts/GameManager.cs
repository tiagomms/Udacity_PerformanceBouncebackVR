using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int score;
	public List<Score> scoreUIList;
	public void IncrementScore() {
		score++;
		foreach (Score item in scoreUIList)
		{
			item.ScoreUIChange();
		}
	}
}
