using UnityEngine;
using System.Collections;

public class MilkboxManagerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision obj)
	{
		if (obj.gameObject.name == "MeshPiece") {
			gameObject.SetActive (false);
			ScoreManagerScript.noOfCrates--;
		}
	}
}
