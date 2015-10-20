
using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using GooglePlayGames.BasicApi;

public class GameOverScript : MonoBehaviour {
	public string achievement1="CgkI04Dx1d4eEAIQAQ";
	public string achievement2="CgkI04Dx1d4eEAIQAw";
	public string achievement3="CgkI04Dx1d4eEAIQBA";
	public string achievement4="CgkI04Dx1d4eEAIQBQ";
	public string achievement5="CgkI04Dx1d4eEAIQBg";
	public string leaderboard="CgkI04Dx1d4eEAIQAg";
	public GameObject topPanel, buttonPanel;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		
		if (ScoreManagerScript.noOfCrates == 0) {
			if(PlayerPrefs.GetInt("highscore",0)<ScoreManagerScript.score){

				PlayerPrefs.SetInt("highscore",ScoreManagerScript.score);
				Social.ReportScore(12345, leaderboard, (bool success) => {
					// handle success or failure
					if(success){

					}
				});

			}








			Time.timeScale = 0;

		}
	}
}
