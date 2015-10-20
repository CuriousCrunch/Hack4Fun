using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HouseDeliveryScript : MonoBehaviour {

	public GameObject scoreTextObject;
	Text scoreText;

	// Use this for initialization
	void Start () {
//		scoreTextObject = GameObject.FindWithTag ("ScoreText");
//		scoreText = scoreTextObject.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider obj)
	{
		if (obj.gameObject.tag == "Truck") {
			for(int i=7; i>=0; i--)
			{
				if(GameObject.Find("Crate (" + i + ")"))
				{
					Destroy(GameObject.Find("Crate (" + i + ")"));
					ScoreManagerScript.noOfHouses += 1;
					ScoreManagerScript.score = ScoreManagerScript.noOfHouses * 10;
					//scoreText.text = ScoreManagerScript.score.ToString();
					ScoreManagerScript.noOfCrates--;
					break;
				}
			}
		}
	}
}
